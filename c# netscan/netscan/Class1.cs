using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
//K8 Cscan 3.1 WebBanner moudle by k8gege
namespace CscanDLL
{
    public class scan
    {
        public static string run(string ip)
        {
            if (string.IsNullOrEmpty(ip))
                return "";
            else
            {
                string hostName = "";
                //return ip+"\r\n";
                //return System.Net.Dns.GetHostByAddress(ip).HostName+"\r\n";
                //192.11.22.10    Microsoft-IIS/10.0      IIS Windows
                //192.11.22.1     H3C-Miniware-Webs       ER3200G2
                //return ip + "\t" + getURLbanner(ip) + "\t" + GetTitle(getHtml("http://" + ip,2))+"\r\n";
                return ip + "\t" + hostName + "\t[" + getURLbanner(ip) + "]\t[" + GetTitle(getHtml("http://" + ip)) + "]"+"\r\n";
                //return ip + "\t" + System.Net.Dns.GetHostByAddress(ip).HostName+"\r\n";


            }

        }

        private static string getURLbanner(string url)
        {

            url = "http://" + url;

            try
            {
                var req = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
                req.Method = "HEAD";
                req.Timeout = 10000;
                var res = (HttpWebResponse)req.GetResponse();

                if (res.StatusCode == HttpStatusCode.OK || res.StatusCode == HttpStatusCode.Forbidden || res.StatusCode == HttpStatusCode.Redirect || res.StatusCode == HttpStatusCode.MovedPermanently)
                {
                    return res.Server;
                }

                //res.Close();

                return res.Server;
            }
            catch (WebException ex)
            {
                return "";
            }
        }

        private static string GetTitle(string html)
        {

            String regex = @"<title>.+</title>";

            String title = Regex.Match(html, regex).ToString();
            title = Regex.Replace(title, @"[\""]+", "");
            return title;

        }

        private static string getHtml(string url)
        {

            try
            {
                if (!url.ToLower().Contains("https://") && !url.ToLower().Contains("http://"))
                    url = "http://" + url;

                WebClient web = new WebClient();
                byte[] buffer = web.DownloadData(url);
                return Encoding.UTF8.GetString(buffer);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

    }
}
