using ComputerInfo.Define;
using System.Management;
using System.Collections.Generic;

namespace ComputerInfo.WMI
{
    class GPU : WMIQuery
    {
        private static class Query
        {
            internal static readonly string WMI = @"select * from  Win32_VideoController";
            internal static readonly string AdapterCompatibility = "AdapterCompatibility";
            internal static readonly string AdapterRAM = "AdapterRAM";
            internal static readonly string Caption = "Caption";
            internal static readonly string CurrentRefreshRate = "CurrentRefreshRate";
            internal static readonly string DriverDate = "DriverDate";
            internal static readonly string DriverVersion = "DriverVersion";
            internal static readonly string MaxRefreshRate = "MaxRefreshRate";
            internal static readonly string MinRefreshRate = "MinRefreshRate";
            internal static readonly string VideoProcessor = "VideoProcessor";
            internal static readonly string VideoModeDescription = "VideoModeDescription";
        }
        public GPU()
        {
            IEnumerator<ManagementBaseObject> enumerator = WMIExecQuery(Query.WMI).GetEnumerator();
            while (enumerator.MoveNext())
            {
                ManagementBaseObject wmi = enumerator.Current;
                AdapterCompatiability = wmi[Query.AdapterCompatibility].ToString();
                AdapterRAM = wmi[Query.AdapterRAM].ToString();
                Caption = wmi[Query.Caption].ToString();
                CurrentRefreshRate = wmi[Query.CurrentRefreshRate].ToString();
                DriverDate = wmi[Query.DriverDate].ToString();
                DriverVersion = wmi[Query.DriverVersion].ToString();
                MaxRefreshRate = wmi[Query.MaxRefreshRate].ToString();
                MinRefreshRate = wmi[Query.MinRefreshRate].ToString();
                VideoModeDescription = wmi[Query.VideoModeDescription].ToString();
                VideoProcessor = wmi[Query.VideoProcessor].ToString();
            }
            DriverDate = DriverDate.Split('.')[0];
        }

        public string AdapterCompatiability { get; private set; }

        public string AdapterRAM { get; private set; }

        public string Caption { get; private set; }

        public string CurrentRefreshRate { get; private set; }

        public string DriverDate { get; private set; }

        public string DriverVersion { get; private set; }

        public string MaxRefreshRate { get; private set; }

        public string MinRefreshRate { get; private set; }

        public string VideoModeDescription { get; private set; }

        public string VideoProcessor { get; private set; }

    }
}
