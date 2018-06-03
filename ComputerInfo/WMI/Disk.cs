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
        public static void Initialization()
        {

        }

        public static Int32 GetVolumeCount => DISK_Volumes.Length;
        public static DriveInfo[] DISK_Volumes { get; } = DriveInfo.GetDrives();
    }
}
