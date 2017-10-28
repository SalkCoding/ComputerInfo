using ComputerInfo.Define;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.WMI
{
    class Memory
    {

        private static UInt64 RAM_Total_Physical_Size;
        private static UInt64 RAM_Total_Virtual_Size;
        private static String RAM_SPEED;
        private static String RAM_VOLTAGE;
        private static Microsoft.VisualBasic.Devices.ComputerInfo info = new Microsoft.VisualBasic.Devices.ComputerInfo();

        public static void Initialization()
        {
            foreach (ManagementObject wmi in new ManagementObjectSearcher(Constants.WMI_RAM).Get())
            {
                try
                {
                    RAM_SPEED = wmi[Constants.WMI_RAM_SPEED].ToString();
                    RAM_VOLTAGE = wmi[Constants.WMI_RAM_VOLTAGE].ToString().Insert(1, ".");
                }
                catch
                {
                    continue;
                }
            }
            RAM_Total_Physical_Size = info.TotalPhysicalMemory;
            RAM_Total_Virtual_Size = info.TotalVirtualMemory;
        }

        public static UInt64 RAM_Pysical_Size => RAM_Total_Physical_Size;

        public static UInt64 RAM_Virtual_Size => RAM_Total_Virtual_Size;

        public static UInt64 RAM_Available_Physical => info.AvailablePhysicalMemory;

        public static UInt64 RAM_Available_Virtual => info.AvailableVirtualMemory;

        public static String RAM_Speed => RAM_SPEED;

        public static String RAM_Voltage => RAM_VOLTAGE;

    }
}
