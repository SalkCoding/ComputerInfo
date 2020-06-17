using System;
using System.Linq;
using System.Management;
using ComputerInfo.Define;

namespace ComputerInfo.WMI
{
    class OS
    {
        public OS()
        {
            foreach (ManagementBaseObject wmi in new ManagementObjectSearcher(WMIQuery.OS.Query).Get())
            {
                String[] MUI;
                try
                {
                    Caption = wmi[WMIQuery.OS.Caption].ToString();
                    Architecture = wmi[WMIQuery.OS.Architecture].ToString();
                    BuildNumber = wmi[WMIQuery.OS.BuildNumber].ToString();
                    Version = wmi[WMIQuery.OS.Version].ToString();
                    SerialNumber = wmi[WMIQuery.OS.SerialNumber].ToString();
                    LastBootUpTime = wmi[WMIQuery.OS.LastBootUpTime].ToString();
                    ContryCode = wmi[WMIQuery.OS.CountryCode].ToString();
                    CurrentTimeZone = wmi[WMIQuery.OS.CurrentTimeZone].ToString();
                    MUI = (String[])wmi[WMIQuery.OS.MUILanguages];
                    Language = wmi[WMIQuery.OS.Language].ToString();
                    InstallTime = ManagementDateTimeConverter.ToDateTime(wmi[WMIQuery.OS.InstallDate].ToString());
                }
                catch
                {
                    continue;
                }
                MUILanguages = String.Join(", ",MUI);
            }
        }

        public String Caption { get; set; }

        public String Architecture { get; set; }

        public String BuildNumber { get; set; }

        public String Version { get; set; }

        public String SerialNumber { get; set; }

        public String ProductKey { get; set; }

        public String ContryCode { get; set; }

        public String CurrentTimeZone { get; set; }

        public String MUILanguages { get; set; }

        public String Language { get; set; }

        public String LastBootUpTime { get; set; }

        public DateTime InstallTime { get; set; }

    }
}
