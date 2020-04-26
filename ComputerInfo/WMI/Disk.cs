using System;
using System.IO;
using System.Collections.Generic;

namespace ComputerInfo.WMI
{
    class Disk
    {
        public Disk()
        {
            VolumeList = new List<DriveInfo>(DriveInfo.GetDrives());
        }

        public Int32 VolumeCount => VolumeList.Count;
        public List<DriveInfo> VolumeList { get; }
    }
}
