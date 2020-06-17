using System;
using System.Management;
using ComputerInfo.Define;

namespace ComputerInfo.WMI
{
    public class CPU
    {
        public CPU()
        {
            foreach (ManagementObject wmi in new ManagementObjectSearcher(WMIQuery.CPU.Query).Get())
            {
                try
                {
                    Name = wmi[WMIQuery.CPU.Name].ToString().Trim();
                    CurrentClock = Convert.ToInt32(wmi[WMIQuery.CPU.MaxClock]);
                    Voltage = Convert.ToDouble(wmi[WMIQuery.CPU.Voltage]) / 10;
                    L2CacheSize = Convert.ToInt32(wmi[WMIQuery.CPU.L2CacheSize]);
                    L3CacheSize = Convert.ToInt32(wmi[WMIQuery.CPU.L3CacheSize]);
                    CoreCount = Convert.ToInt32(wmi[WMIQuery.CPU.NumberOfCores]);
                    ThreadCount = Convert.ToInt32(wmi[WMIQuery.CPU.ThreadCount]);
                }
                catch
                {
                    continue;
                }
            }
        }

        public String Name { get; private set; }

        public Int32 CurrentClock { get; private set; }

        public Double Voltage { get; private set; }

        public Int32 L2CacheSize { get; private set; }

        public Int32 L3CacheSize { get; private set; }

        public Int32 CoreCount { get; private set; }

        public Int32 ThreadCount { get; private set; }
    }
}
