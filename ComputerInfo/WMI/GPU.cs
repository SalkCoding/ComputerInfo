using System;
using ComputerInfo.Define;
using System.Management;

namespace ComputerInfo.WMI
{
    class GPU
    {
        public GPU()
        {
            foreach (ManagementObject wmi in new ManagementObjectSearcher(WMIQuery.GPU.Query).Get())
            {
                try
                {
                    AdapterCompatiability = wmi[WMIQuery.GPU.AdapterCompatibility].ToString();
                    AdapterRAM = wmi[WMIQuery.GPU.AdapterRAM].ToString();
                    Caption = wmi[WMIQuery.GPU.Caption].ToString();
                    CurrentRefreshRate = wmi[WMIQuery.GPU.CurrentRefreshRate].ToString();
                    DriverDate = wmi[WMIQuery.GPU.DriverDate].ToString();
                    DriverVersion = wmi[WMIQuery.GPU.DriverVersion].ToString();
                    MaxRefreshRate = wmi[WMIQuery.GPU.MaxRefreshRate].ToString();
                    MinRefreshRate = wmi[WMIQuery.GPU.MinRefreshRate].ToString();
                    VideoModeDescription = wmi[WMIQuery.GPU.VideoModeDescription].ToString();
                    VideoProcessor = wmi[WMIQuery.GPU.VideoProcessor].ToString();
                }
                catch
                {
                    continue;
                }
            }
            DriverDate = DriverDate.Split('.')[0];
        }

        public String AdapterCompatiability { get; private set; }

        public String AdapterRAM { get; private set; }

        public String Caption { get; private set; }

        public String CurrentRefreshRate { get; private set; }

        public String DriverDate { get; private set; }

        public String DriverVersion { get; private set; }

        public String MaxRefreshRate { get; private set; }

        public String MinRefreshRate { get; private set; }

        public String VideoModeDescription { get; private set; }

        public String VideoProcessor { get; private set; }

    }
}
