using System;
using System.Collections.Generic;
using System.Management;
using ComputerInfo.Define;

namespace ComputerInfo.WMI
{
    class OS : WMIQuery
    {
        private static class Query
        {
            internal static readonly string WMI = @"select * from  Win32_OperatingSystem";
            internal static readonly string Caption = "Caption";
            internal static readonly string Architecture = "OSArchitecture";
            internal static readonly string BuildNumber = "BuildNumber";
            internal static readonly string Version = "Version";
            internal static readonly string SerialNumber = "SerialNumber";
            internal static readonly string LastBootUpTime = "LastBootUpTime";
            internal static readonly string CountryCode = "CountryCode";
            internal static readonly string CurrentTimeZone = "CurrentTimeZone";
            internal static readonly string MUILanguages = "MUILanguages";
            internal static readonly string Language = "OSLanguage";
            internal static readonly string InstallDate = "InstallDate";
        }

        public OS()
        {
            IEnumerator<ManagementBaseObject> enumerator = WMIExecQuery(Query.WMI).GetEnumerator();
            while (enumerator.MoveNext())
            {
                ManagementBaseObject wmi = enumerator.Current;
                Caption = wmi[Query.Caption].ToString();
                Architecture = wmi[Query.Architecture].ToString();
                BuildNumber = wmi[Query.BuildNumber].ToString();
                Version = wmi[Query.Version].ToString();
                SerialNumber = wmi[Query.SerialNumber].ToString();
                LastBootUpTime = wmi[Query.LastBootUpTime].ToString();
                CountryCode = wmi[Query.CountryCode].ToString();
                CurrentTimeZone = wmi[Query.CurrentTimeZone].ToString();
                MUILanguages = string.Join(", ", (string[])wmi[Query.MUILanguages]);
                Language = wmi[Query.Language].ToString();
                InstallTime = ManagementDateTimeConverter.ToDateTime(wmi[Query.InstallDate].ToString());
            }
        }

        public string Caption { get; private set; }

        public string Architecture { get; private set; }

        public string BuildNumber { get; private set; }

        public string Version { get; private set; }

        public string SerialNumber { get; private set; }

        public string ProductKey { get; private set; }

        public string CountryCode { get; private set; }

        public string CurrentTimeZone { get; private set; }

        public string MUILanguages { get; private set; }

        public string Language { get; private set; }

        public string LastBootUpTime { get; private set; }

        public DateTime InstallTime { get; private set; }

    }
}
