using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace iLOViewer
{
    public class iLOHttpClient
    {
        private CookieContainer cookieContainer = null;

        public bool Https { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        static iLOHttpClient()
        {
            ServicePointManager.DefaultConnectionLimit = 256;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RemoteCertificateValidation);
        }

        public static bool RemoteCertificateValidation(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        public string GetCookieValue(string url, string name)
        {
            if (this.cookieContainer != null)
            {
                CookieCollection loginCookies = this.cookieContainer.GetCookies(new Uri(this.GetFullUrl(url)));

                foreach (Cookie cookie in loginCookies)
                {
                    if (cookie.Name.Equals(name))
                    {
                        return cookie.Value;
                    }
                }
            }

            return null;
        }

        public JObject DoJsonRequest(string method, string url, JObject jbody)
        {
            string body = null;
            if (jbody != null)
            {
                body = jbody.ToString();
            }

            HttpWebResponse httpWebResponse = this.DoRequest(method, url, body);
            string responseBody = GetResponseBody(httpWebResponse);

            if (string.IsNullOrWhiteSpace(responseBody))
            {
                return null;
            }

            JObject jObject = JObject.Parse(responseBody);
            httpWebResponse.Close();

            return jObject;
        }

        public async Task<JObject> DoJsonRequestAsync(string method, string url, JObject jbody)
        {
            return await Task.Run(
                () =>
                {
                    return this.DoJsonRequest(method, url, jbody);
                });
        }

        public HttpWebResponse DoRequest(string method, string url, string body)
        {
            if (this.cookieContainer == null)
            {
                cookieContainer = new CookieContainer();
            }

            HttpWebRequest httpWebRequest = HttpWebRequest.CreateHttp(this.GetFullUrl(url));
            httpWebRequest.Method = method;
            httpWebRequest.CookieContainer = this.cookieContainer;
            httpWebRequest.Accept = "application/json, */*";
            httpWebRequest.KeepAlive = false;
            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";
            httpWebRequest.Headers.Add("X-Requested-With:XMLHttpRequest");

            if (!string.IsNullOrEmpty(body))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(body);
                httpWebRequest.ContentLength = bytes.Length;

                using (Stream requestStream = httpWebRequest.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                }
            }

            return (HttpWebResponse)httpWebRequest.GetResponse();
        }

        public async Task<HttpWebResponse> DoRequestAsync(string method, string url, string body)
        {
            return await Task.Run(
                () =>
                {
                    return this.DoRequest(method, url, body);
                });
        }

        public string GetFullUrl(string url)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (this.Https)
            {
                stringBuilder.Append("https://");
            }
            else
            {
                stringBuilder.Append("http://");
            }

            stringBuilder.Append(this.Host);
            stringBuilder.Append(":");
            stringBuilder.Append(this.Port);
            stringBuilder.Append("/");
            stringBuilder.Append(url);

            return stringBuilder.ToString();
        }

        public static string GetResponseBody(HttpWebResponse httpWebResponse)
        {
            string body = null;

            using (Stream responseStream = httpWebResponse.GetResponseStream())
            {
                StreamReader streamReader = new StreamReader(responseStream);
                body = streamReader.ReadToEnd();
            }

            httpWebResponse.Close();

            return body;
        }
    }
}
