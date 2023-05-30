using ComputerInfo.Define;
using System;
using System.Linq;
using System.Management;

namespace ComputerInfo.WMI
{
    class DetailStorage : WMIQuery
    {
        private static class Query
        {
            internal static readonly string DiskDriveWMI = @"select * from  Win32_DiskDrive";
            internal static readonly string Caption = "Caption";
            internal static readonly string DeviceID = "DeviceID";
            internal static readonly string Model = "Model";
            internal static readonly string FileSystem = "FileSystem";
            internal static readonly string VolumeName = "VolumeName";
            internal static readonly string Size = "Size";
            internal static readonly string FreeSpace = "FreeSpace";
            internal static readonly string Status = "Status";
            internal static readonly string SystemName = "SystemName";
            internal static readonly string Name = "Name";
            internal static readonly string SerialNumber = "SerialNumber";
            internal static readonly string VolumeSerialNumber = "VolumeSerialNumber";
            internal static readonly string Signature = "Signature";
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
