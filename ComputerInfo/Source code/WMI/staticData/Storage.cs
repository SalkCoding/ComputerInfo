using System;
using System.IO;
using System.Collections.Generic;
using ComputerInfo.Define;

namespace ComputerInfo.WMI
{
    class Storage : WMIQuery
    {

        public Storage()
        {
            VolumeList = new List<DriveInfo>(DriveInfo.GetDrives());
        }

        public int VolumeCount => VolumeList.Count;
        public List<DriveInfo> VolumeList { get; }
    }
}
