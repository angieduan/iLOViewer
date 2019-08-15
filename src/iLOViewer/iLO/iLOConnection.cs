using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLOViewer
{
    public class iLOConnection
    {
        public string Name { get; set; }

        public bool Https { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string UserPassword { get; set; }

        public bool IsRunning { get; private set; }
        public bool IsConnected { get; private set; }
        public DateTime NextAttempt { get; private set; }
        public string Status { get; private set; }

        public JObject SystemInfo { get; private set; }

        private iLOHttpClient iLOHttpClient = new iLOHttpClient();
        private string sessionKey = string.Empty;

        public async void Login()
        {
            try
            {
                if (!this.IsRunning)
                {
                    this.IsRunning = true;

                    this.Status = "Connecting...";

                    this.iLOHttpClient.Https = this.Https;
                    this.iLOHttpClient.Host = this.Host;
                    this.iLOHttpClient.Port = this.Port;

                    JObject jBody = new JObject()
                    {
                        {"method", "login"},
                        {"user_login", this.User},
                        {"password", this.UserPassword}
                    };

                    JObject json = await this.iLOHttpClient.DoJsonRequestAsync("POST", "json/login_session", jBody);
                    this.sessionKey = json["session_key"].ToString();

                    this.IsRunning = false;

                    this.UpdateSystemInfo();
                }
            }
            catch
            {
                this.SetFailStatus();

                this.IsRunning = false;
            }
        }

        public void Logout()
        {
            JObject jBody = new JObject()
            {
                {"method", "logout"},
                {"session_key", this.sessionKey}
            };

            this.iLOHttpClient.DoJsonRequest("POST", "json/login_session", jBody);

            this.IsConnected = false;
        }

        public async void UpdateSystemInfo()
        {
            try
            {
                if (!this.IsRunning)
                {
                    this.IsRunning = true;

                    JObject jOverview = await this.iLOHttpClient.DoJsonRequestAsync("GET", "json/overview", null);
                    JObject jFan = await this.iLOHttpClient.DoJsonRequestAsync("GET", "json/health_fans", null);
                    JObject jTemp = await this.iLOHttpClient.DoJsonRequestAsync("GET", "json/health_temperature", null);

                    this.SystemInfo = new JObject()
                    {
                        {"Overview", jOverview},
                        {"Fan", jFan},
                        {"Temp", jTemp},
                        {"LastRefresh", DateTime.Now.ToString("HH:mm:ss")}
                    };

                    this.IsConnected = true;
                    this.Status = "";

                    this.IsRunning = false;
                }
            }
            catch
            {
                this.SetFailStatus();

                this.IsRunning = false;
            }
        }

        private void SetFailStatus()
        {
            this.IsConnected = false;
            this.Status = "Failed to connect this iLO.";
            this.NextAttempt = DateTime.Now.AddMinutes(2);
        }

        public void PowerMomentaryPress()
        {
            JObject jBody = new JObject()
            {
                {"method", "press_power_button"},
                {"session_key", this.sessionKey}
            };

            this.iLOHttpClient.DoJsonRequest("POST", "json/host_power", jBody);
        }

        public void PressAndHold()
        {
            JObject jBody = new JObject()
            {
                {"method", "hold_power_button"},
                {"session_key", this.sessionKey }
            };

            this.iLOHttpClient.DoJsonRequest("POST", "json/host_power", jBody);
        }

        public void ColdBoot()
        {
            JObject jBody = new JObject()
            {
                {"method", "system_coldboot"},
                {"session_key", this.sessionKey }
            };
            this.iLOHttpClient.DoJsonRequest("POST", "json/host_power", jBody);
        }

        public void Reset()
        {
            JObject jBody = new JObject()
            {
                {"method", "system_reset"},
                {"session_key", this.sessionKey }
            };
            this.iLOHttpClient.DoJsonRequest("POST", "json/host_power", jBody);
        }

        public void OpenDotNetRemoteConsole(string ircPath)
        {
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo(ircPath);
                process.StartInfo.Arguments = string.Format("-addr {0}:{1} -name {2} -password {3}", this.Host, this.Port, this.User, this.UserPassword);

                process.Start();
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
