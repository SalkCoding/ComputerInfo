using ComputerInfo.Define;
using System;
using System.Management;

namespace ComputerInfo.WMI
{
    class Memory
    {
        private static Microsoft.VisualBasic.Devices.ComputerInfo info = new Microsoft.VisualBasic.Devices.ComputerInfo();

        public static void Initialization()
        {
            foreach (ManagementObject wmi in new ManagementObjectSearcher(WMIQuery.WMI_RAM).Get())
            {
                try
                {
                    RAM_Speed = wmi[WMIQuery.WMI_RAM_SPEED].ToString();
                    RAM_Voltage = wmi[WMIQuery.WMI_RAM_VOLTAGE].ToString().Insert(1, ".");
                }
                catch
                {
                    continue;
                }
            }
            RAM_Pysical_Size = info.TotalPhysicalMemory;//info.TotalPhysicalMemory == 0 ? 1 : info.TotalPhysicalMemory;
            RAM_Virtual_Size = info.TotalVirtualMemory;//info.TotalVirtualMemory == 0 ? 1 : info.TotalVirtualMemory;
        }

        public static UInt64 RAM_Pysical_Size { get; private set; }

        public static UInt64 RAM_Virtual_Size { get; private set; }

        public static UInt64 RAM_Available_Physical => info.AvailablePhysicalMemory;

        public static UInt64 RAM_Available_Virtual => info.AvailableVirtualMemory;

        public static String RAM_Speed { get; private set; }

        public static String RAM_Voltage { get; private set; }
    }
}
