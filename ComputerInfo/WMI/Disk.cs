using System;
using System.IO;
using System.Management;
using ComputerInfo.Define;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.WMI
{
    class Disk
    {
        private static DriveInfo[] DISK_list = DriveInfo.GetDrives();
        private static List<String> DISK_Model = new List<string>();
        private static List<String> DISK_Serial_Number = new List<string>();

        public static void Initialization()
        {
            foreach (ManagementObject driver in new ManagementObjectSearcher(Constants.WMI_DISK).Get())
            {
                DISK_Model.Add(driver[Constants.WMI_DISK_MODEL].ToString());
                DISK_Serial_Number.Add(driver[Constants.WMI_DISK_SERIAL_NUMBER].ToString());
            }
        }

        public static String[] Disk_Model => DISK_Model.ToArray<String>();
        public static String[] Disk_Serial_Number => DISK_Serial_Number.ToArray<String>();

        public static Int32 GetVolumeCount => DISK_list.Length;
        public static DriveInfo[] DISK_Volumes => DISK_list;
    }
}
