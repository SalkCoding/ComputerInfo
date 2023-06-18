using ComputerInfo.Define;
using System;
using System.Linq;
using System.Management;

namespace ComputerInfo.WMI
{
    class DetailStorage : WMIQuery
    {
        public static class Query
        {
            public static readonly string DiskDriveWMI = @"select * from  Win32_DiskDrive";
            public static readonly string Caption = "Caption";
            public static readonly string DeviceID = "DeviceID";
            public static readonly string Model = "Model";
            public static readonly string FileSystem = "FileSystem";
            public static readonly string VolumeName = "VolumeName";
            public static readonly string Size = "Size";
            public static readonly string FreeSpace = "FreeSpace";
            public static readonly string Status = "Status";
            public static readonly string SystemName = "SystemName";
            public static readonly string Name = "Name";
            public static readonly string SerialNumber = "SerialNumber";
            public static readonly string VolumeSerialNumber = "VolumeSerialNumber";
            public static readonly string Signature = "Signature";
        }

        public DetailStorage()
        {
            DiskDrives = WMIExecQuery(Query.DiskDriveWMI)
                .OrderBy(d => d["Index"].ToString()) // disk index
                .ToArray();
        }

        public ManagementBaseObject[] DiskDrives { get; }

        public string GetDeviceID(int index)
        {
            if (index >= DiskDrives.Length) return "Unknown";
            return DiskDrives[index][Query.DeviceID].ToString();
        }

        public string GetModel(int index)
        {
            if (index >= DiskDrives.Length) return "Unknown";
            return DiskDrives[index][Query.Model].ToString();
        }

        public string ComputeDiskSize(int index)
        {
            if (index >= DiskDrives.Length) return "Unknown";
            return DiskDrives[index][Query.Size].ToString()
                + string.Format(" Byte({0:0.00}GB)", Convert.ToDouble(DiskDrives[index][Query.Size]) / Constants.GIGABYTE_DIVIDE_CONSTANTS);
        }

        public string GetStatus(int index)
        {
            if (index >= DiskDrives.Length) return "Unknown";
            return DiskDrives[index][Query.Status].ToString();
        }

        public string GetSystemName(int index)
        {
            if (index >= DiskDrives.Length) return "Unknown";
            return DiskDrives[index][Query.SystemName].ToString();
        }

        public string GetName(int index)
        {
            if (index >= DiskDrives.Length) return "Unknown";
            return DiskDrives[index][Query.Name].ToString();
        }

        public string GetSerialNumber(int index)
        {
            if (index >= DiskDrives.Length) return "Unknown";
            return DiskDrives[index][Query.SerialNumber].ToString();
        }

        public string GetSignature(int index)
        {
            if (index >= DiskDrives.Length) return "Unknown";
            var signature = DiskDrives[index][Query.Signature];
            return signature != null ? signature.ToString() : "Unknown";
        }
    }
}
