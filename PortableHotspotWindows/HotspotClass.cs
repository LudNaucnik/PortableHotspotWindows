using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PortableHotspotWindows
{
    public class HotspotClass
    {
        private ProcessStartInfo ps = null;
        private dynamic netSharingManager = null;
        private dynamic everyConnections = null;
        private bool hasNetSharingManager = false;
        public string Message { get; set; } = "";
        public Boolean WriteLog { get; set; } = false;

        public HotspotClass()
        {
            InitializeNetwork();
        }

        public void InitializeNetwork()
        {
            ps = new ProcessStartInfo("cmd.exe");
            ps.UseShellExecute = false;
            ps.RedirectStandardOutput = true;
            ps.CreateNoWindow = true;
            ps.FileName = "netsh";

            netSharingManager = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.HNetShare.1"));

            if (netSharingManager == null)
            {
                this.Message = "HNetCfg.HNetShare.1 was not found! \n";
                LoggerClass.WriteLogError(Message);
                hasNetSharingManager = true;
            }
            else
            {
                hasNetSharingManager = false;
            }

            if (netSharingManager.SharingInstalled == false)
            {
                this.Message = "Sharing on this platform is not available \n";
                LoggerClass.WriteLogError(Message);
                hasNetSharingManager = false;
            }
            else
            {
                hasNetSharingManager = true;
            }

            if (hasNetSharingManager)
            {
                everyConnections = netSharingManager.EnumEveryConnection;

            }

        }

        public bool Execute(ProcessStartInfo ps)
        {
            Message = "";
            bool isExecuted = false;
            try
            {
                using (Process p = Process.Start(ps))
                {
                    Message += p.StandardOutput.ReadToEnd() + "\n";
                    p.WaitForExit();
                    isExecuted = true;
                }
            }
            catch (Exception e)
            {
                Message = "";
                Message += e.Message;
                isExecuted = false;
            }
            return isExecuted;
        }

        public void Start()
        {
            Message = "";
            ps.Arguments = "wlan start hosted network";
            Execute(ps);
            LoggerClass.WriteLogInformation(Message);
        }
        public void Create(String ssid, String key)
        {
            Message = "";
            ps.Arguments = @"wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + key;
            Execute(ps);
            LoggerClass.WriteLogInformation(Message);
        }
        public void Stop()
        {
            Message = "";
            ps.Arguments = "wlan stop hosted network";
            Execute(ps);
            LoggerClass.WriteLogInformation(Message);
        }

        public NetworkInfoClass GetNetworkInfo()
        {
            Message = "";
            NetworkInfoClass Info = new NetworkInfoClass();
            ps.Arguments = "wlan show hostednetwork";
            Execute(ps);
            try
            {
                Info.NetworkStatus = (Regex.Match(Message, @"[\n\r].*Status                 : \s*([^\n\r]*)")).Groups[1].Value;
            }
            catch (Exception)
            {
                Info.NetworkStatus = null;
            }
            try
            {
                Info.SSID = (Regex.Match(Message, @"[\n\r].*SSID name              : \s*([^\n\r]*)")).Groups[1].Value.Replace("\"", "");
            }
            catch (Exception)
            {
                Info.SSID = null;
            }
            try
            {
                Info.NumOfClients = (Regex.Match(Message, @"[\n\r].*Number of clients      : \s*([^\n\r]*)")).Groups[1].Value;
            }
            catch (Exception)
            {
                Info.NumOfClients = "0";
            }
            try
            {
                MatchCollection Clients = Regex.Matches(Message, @"([0-9a-f]{2}(?::[0-9a-f]{2}){5})");
                foreach (Match ClientMAC in Clients)
                {
                    foreach (Capture CaptureMAC in ClientMAC.Captures)
                    {
                        Info.ConnectedClients.Add(CaptureMAC.Value);
                    }
                }
            }
            catch (Exception)
            {
                Info.ConnectedClients = null;
            }
            if (WriteLog == true)
            {
                LoggerClass.WriteLogInformation(Message);
            }
            Message = "";
            ps.Arguments = "wlan show  hostednetwork setting=security";
            Execute(ps);
            try
            {
                Info.Key = (Regex.Match(Message, @"[\n\r].*User security key      : \s*([^\n\r]*)")).Groups[1].Value;
            }
            catch (Exception)
            {
                Info.Key = null;
            }
            if (WriteLog == true)
            {
                LoggerClass.WriteLogInformation(Message);
            }
            return Info;
        }

        public List<String> GetConnections()
        {
            dynamic everyConnection = null;
            dynamic connectionProp = null;
            everyConnections = netSharingManager.EnumEveryConnection;
            List<String> connections = new List<string>();
            foreach (dynamic connection in everyConnections)
            {
                everyConnection = netSharingManager.INetSharingConfigurationForINetConnection(connection);
                connectionProp = netSharingManager.NetConnectionProps(connection);
                connections.Add(connectionProp.Name);
            }

            return connections;
        }

        public void ShareInternet(String pubConnectionName, String priConnectionName, bool isEnabled)
        {
            Message = "";
            bool hasCon = false;
            dynamic everyConnection = null;
            dynamic connectionProp = null;
            everyConnections = netSharingManager.EnumEveryConnection;
            foreach (dynamic connection in everyConnections)
            {
                everyConnection = netSharingManager.INetSharingConfigurationForINetConnection(connection);
                connectionProp = netSharingManager.NetConnectionProps(connection);

                if (connectionProp.Name == pubConnectionName)
                {
                    hasCon = true;
                    this.Message += String.Format("Setting ICS Public {0} on connection: {1} \n", isEnabled, pubConnectionName);
                    if (isEnabled)
                    {
                        everyConnection.EnableSharing(0);
                    }
                    else
                    {
                        everyConnection.DisableSharing();
                    }
                }

                if (connectionProp.Name == priConnectionName)
                {
                    hasCon = true;
                    this.Message += String.Format("Setting ICS Private {0} on connection: {1} \n", isEnabled, priConnectionName);
                    if (isEnabled)
                    {
                        everyConnection.EnableSharing(1);
                    }
                    else
                    {
                        everyConnection.DisableSharing();
                    }
                }
            }
            LoggerClass.WriteLogInformation(Message);
            if (!hasCon)
            {
                this.Message += "No connection found!";
            }
        }
    }
}
