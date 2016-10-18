using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLOViewer
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private delegate void delegateAction();

        private string appConfigPath = "Config.json";
        private JObject appConfig = null;

        private List<iLOConnection> iLOConnList = new List<iLOConnection>();

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.LoadAppConfig();

            // Update IRC.exe path
            string newIRCPath = this.GetIRCPath();
            if (newIRCPath != null)
            {
                appConfig["IRCPath"] = newIRCPath;

                this.SaveAppConfig();
            }

            if (appConfig["Servers"] != null)
            {
                foreach (var server in appConfig["Servers"])
                {
                    iLOConnection iLOConn = new iLOConnection();
                    iLOConn.Name = (string)server["Name"];
                    iLOConn.Https = (bool)server["Https"];
                    iLOConn.Host = (string)server["Host"];
                    iLOConn.Port = (int)server["Port"];
                    iLOConn.User = (string)server["User"];
                    iLOConn.UserPassword = (string)server["Password"];

                    iLOConn.Login();

                    this.listBox_iLOList.Items.Add(iLOConn.ToString());
                    iLOConnList.Add(iLOConn);
                }
            }

            this.timer_ShowServerInfo_Tick(null, null);
            this.timer_ShowServerInfo.Enabled = true;

            if (this.listBox_iLOList.Items.Count > 0)
            {
                this.listBox_iLOList.SelectedIndex = 0;
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_ShowServerInfo.Enabled = false;

            if (this.iLOConnList != null)
            {
                foreach (var iLOConn in this.iLOConnList)
                {
                    if (iLOConn.IsConnected)
                    {
                        iLOConn.Logout();
                    }
                }
            }

            e.Cancel = false;
        }

        private void LoadAppConfig()
        {
            string configfileContent = File.ReadAllText(this.appConfigPath);
            this.appConfig = JObject.Parse(configfileContent);
        }

        private void SaveAppConfig()
        {
            File.WriteAllText(this.appConfigPath, appConfig.ToString());
        }

        private string GetIRCPath()
        {
            var processes = Process.GetProcessesByName("IRC");

            if (processes.Length > 0)
            {
                return processes.First().MainModule.FileName;
            }

            return null;
        }

        private void ShowFan(JObject json)
        {
            this.listView_Fan.Items.Clear();
            foreach (var item in json["fans"])
            {
                string[] data = new string[]{
                    (string)item["label"],
                    ((string)item["status"]).Replace("OP_STATUS_", ""),
                    string.Format("{0}%",(string)item["speed"])
                };

                this.listView_Fan.Items.Add(new ListViewItem(data));
            }
        }

        private void ShowTemp(JObject json)
        {
            this.listView_Temp.Items.Clear();
            foreach (var item in json["temperature"])
            {
                string[] data = new string[]{
                    (string)item["label"],
                    ((string)item["status"]).Replace("OP_STATUS_", ""),
                    (string)item["currentreading"] != "0" ? string.Format("{0}C", (string)item["currentreading"]) : "-",
                    (string)item["caution"] != "0" ? string.Format("{0}C", (string)item["caution"]) : "-",
                    (string)item["critical"] != "0" ? string.Format("{0}C", (string)item["critical"]) : "-"
                };

                this.listView_Temp.Items.Add(new ListViewItem(data));
            }
        }

        private void ShowPowerState(JObject json)
        {
            this.toolStripStatusLabel_ServerPower.Text = (string)json["power"];
        }

        private void UpdateUIData()
        {
            iLOConnection iLOConn = this.iLOConnList[this.listBox_iLOList.SelectedIndex];

            if (iLOConn.IsConnected)
            {
                this.ShowFan(iLOConn.SystemInfo["Fan"].ToObject<JObject>());
                this.ShowTemp(iLOConn.SystemInfo["Temp"].ToObject<JObject>());
                this.ShowPowerState(iLOConn.SystemInfo["Overview"].ToObject<JObject>());
                this.toolStripStatusLabel_ServerStatus.Text = ((string)iLOConn.SystemInfo["Overview"]["system_health"]).Replace("OP_STATUS_", "");
                this.toolStripStatusLabel_LastRefresh.Text = (string)iLOConn.SystemInfo["LastRefresh"];
            }
            else
            {
                this.listView_Fan.Items.Clear();
                this.listView_Temp.Items.Clear();
                this.toolStripStatusLabel_ServerStatus.Text = "-";
                this.toolStripStatusLabel_ServerPower.Text = "Disconnected";
                this.toolStripStatusLabel_LastRefresh.Text = "-";
            }

            this.toolStripStatusLabel_ConnStatus.Text = iLOConn.Status;
        }

        private void timer_ShowServerInfo_Tick(object sender, EventArgs e)
        {
            foreach (var iLOConn in this.iLOConnList)
            {
                if (iLOConn.IsConnected && !iLOConn.IsRunning)
                {
                    iLOConn.UpdateSystemInfo();
                }
            }

            // Update UI
            this.listBox_iLOList_SelectedIndexChanged(null, null);

            // Update NotifyIcon Text
            StringBuilder sbNotifyIconText = new StringBuilder();

            foreach (var iLOConn in this.iLOConnList)
            {
                if (iLOConn.IsConnected)
                {
                    sbNotifyIconText.AppendLine(string.Format("{0} {1} {2}", iLOConn.Name, ((string)iLOConn.SystemInfo["Overview"]["system_health"]).Replace("OP_STATUS_", ""), iLOConn.SystemInfo["Overview"]["power"]));
                }
                else
                {
                    sbNotifyIconText.AppendLine(string.Format("{0} {1}", iLOConn.Name, "Disconnected"));
                }
            }

            if (sbNotifyIconText.Length > 63)
            {
                this.notifyIcon_Main.Text = string.Format("{0}{1}", sbNotifyIconText.ToString().Substring(0, 59), "...");
            }
            else
            {
                this.notifyIcon_Main.Text = sbNotifyIconText.ToString();
            }
        }

        private void toolStripMenuItem_Action_Power_MomentaryPress_Click(object sender, EventArgs e)
        {
            if (this.listBox_iLOList.SelectedIndex >= 0)
            {
                this.iLOConnList[this.listBox_iLOList.SelectedIndex].PowerMomentaryPress();
            }
        }

        private void toolStripMenuItem_Action_RemoteConsole_DotNet_Click(object sender, EventArgs e)
        {
            if (File.Exists((string)appConfig["IRCPath"]))
            {
                if (this.listBox_iLOList.SelectedIndex >= 0)
                {
                    this.iLOConnList[this.listBox_iLOList.SelectedIndex].OpenDotNetRemoteConsole((string)appConfig["IRCPath"]);
                }
            }
            else
            {
                MessageBox.Show("IRC.exe is NOT found, please follow these steps to update the IRC.exe path:\r\n1. Open iLO web and login.\r\n2. Launch Integrated Remote Console (.Net) from iLO web.\r\n3. Close and restart this application.\r\nThen the IRC.exe path will be automatically updated.\r\n");
            }
        }

        private void listBox_iLOList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox_iLOList.SelectedIndex >= 0)
            {
                this.toolStripStatusLabel_ServerIP.Text = this.iLOConnList[this.listBox_iLOList.SelectedIndex].Host;
                this.UpdateUIData();
            }
        }

        private void toolStripMenuItem_Action_DropDownOpened(object sender, EventArgs e)
        {
            if (this.listBox_iLOList.SelectedIndex >= 0)
            {
                if (this.iLOConnList[this.listBox_iLOList.SelectedIndex].IsConnected)
                {
                    this.toolStripMenuItem_Action_Power.Enabled = true;
                    this.toolStripMenuItem_Action_RemoteConsole.Enabled = true;

                    return;
                }
            }

            this.toolStripMenuItem_Action_Power.Enabled = false;
            this.toolStripMenuItem_Action_RemoteConsole.Enabled = false;
        }

        private void toolStripMenuItem_NotifyIcon_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_Main_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
