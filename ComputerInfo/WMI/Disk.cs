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
        private static List<String> DISK_MODEL = new List<String>();
        private static List<String> DISK_SERIAL_NUMBER = new List<String>();
        private static List<String> DISK_VOLUME_NAME = new List<String>();
        private static List<String> DISK_VOLUME_SERIAL_NUMBER = new List<String>();

        public static void Initialization()
        {
            //have to reverse
            foreach (ManagementObject driver in new ManagementObjectSearcher(Constants.WMI_DISK).Get())
            {
                DISK_MODEL.Add(driver[Constants.WMI_DISK_MODEL].ToString());
                DISK_SERIAL_NUMBER.Add(driver[Constants.WMI_DISK_SERIAL_NUMBER].ToString());
            }
            //not have to reverse
            foreach (ManagementObject driver in new ManagementObjectSearcher(Constants.WMI_DISK_LOGICAL).Get())
            {
                DISK_VOLUME_NAME.Add(driver[Constants.WMI_DISK_LOGICAL_VOLUME_NAME].ToString());
                DISK_VOLUME_SERIAL_NUMBER.Add(driver[Constants.WMI_DISK_LOGICAL_SERIAL_NUMBER].ToString());
            }

            DISK_MODEL.Reverse();
            DISK_SERIAL_NUMBER.Reverse();
        }

        public static String[] Disk_Model => DISK_MODEL.ToArray<String>();
        public static String[] Disk_Serial_Number => DISK_SERIAL_NUMBER.ToArray<String>();
        public static String[] Disk_Volume_Name => DISK_VOLUME_NAME.ToArray<String>();
        public static String[] Disk_Volume_Serial_Number => DISK_VOLUME_SERIAL_NUMBER.ToArray<String>();

        public static Int32 GetVolumeCount => DISK_list.Length;
        public static DriveInfo[] DISK_Volumes => DISK_list;
    }
}
