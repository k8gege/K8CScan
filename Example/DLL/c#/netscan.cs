namespace CscanDLL 
{  
    public class scan  
    {  
        public static string run(string ip)  
        {  
            if (string.IsNullOrEmpty(ip))  
                return "";  
            else  
                return ip;
                //return System.Net.Dns.GetHostByAddress(ip).HostName;			
        }  
    }  
}