using System;
using System.Collections.Generic;
using System.Management;

namespace ComputerInfo.Define
{
    public static class WMIQuery
    {
        public static IEnumerable<ManagementBaseObject> WMIExecQuery(string query)
        {
            using (var searcher = new ManagementObjectSearcher(query))
            {
                using (var collection = searcher.Get())
                {
                    foreach (ManagementBaseObject item in collection)
                    {
                        yield return item;
                    }
                }
            }
        }

        public static class CPU
        {
            public static readonly String Query = "select * from  Win32_Processor";
            public static readonly String Name = "Name";
            public static readonly String MaxClock = "MaxClockSpeed";
            public static readonly String Voltage = "CurrentVoltage";
            public static readonly String L2CacheSize = "L2CacheSize";
            public static readonly String L3CacheSize = "L3CacheSize";
            public static readonly String NumberOfCores = "NumberOfCores";
            public static readonly String ThreadCount = "ThreadCount";
        }

        public static class Bios
        {
            public static readonly String Query = @"HARDWARE\DESCRIPTION\System\BIOS";
            public static readonly String BaseBoardManufacturer = "BaseBoardManufacturer";
            public static readonly String BaseBoardProduct = "BaseBoardProduct";
            public static readonly String BaseBoardVersion = "BaseBoardVersion";
            public static readonly String BiosReleaseDate = "BIOSReleaseDate";
            public static readonly String BiosVersion = "BIOSVersion";
            public static readonly String BiosVendor = "BIOSVendor";
            public static readonly String SystemProductName = "SystemProductName";
            public static readonly String SystemManufacturer = "SystemManufacturer";
            public static readonly String SystemVersion = "SystemVersion";
        }

        public static class RAM
        {
            public static readonly String Query = "select * from  Win32_PhysicalMemory";
            public static readonly String Speed = "Speed";
            public static readonly String ConfiguredVoltage = "ConfiguredVoltage";
            public static readonly String Manufacturer = "Manufacturer";
        }

        public static class Disk
        {
            public static readonly String DiskDriveQuery = "select * from  Win32_DiskDrive";
            public static readonly String LogicalDiskQuery = "select * from  Win32_LogicalDisk";
            public static readonly String LogicalToPartitionQuery = "select * from  Win32_LogicalDiskToPartition";
            public static readonly String Caption = "Caption";
            public static readonly String DeviceID = "DeviceID";
            public static readonly String Model = "Model";
            public static readonly String FileSystem = "FileSystem";
            public static readonly String VolumeName = "VolumeName";
            public static readonly String Size = "Size";
            public static readonly String FreeSpace = "FreeSpace";
            public static readonly String Status = "Status";
            public static readonly String SystemName = "SystemName";
            public static readonly String Name = "Name";
            public static readonly String SerialNumber = "SerialNumber";
            public static readonly String VolumeSerialNumber = "VolumeSerialNumber";
            public static readonly String Signature = "Signature";
        }

        public static class GPU
        {
            public static readonly String Query = "select * from  Win32_VideoController";
            public static readonly String AdapterCompatibility = "AdapterCompatibility";
            public static readonly String AdapterRAM = "AdapterRAM";
            public static readonly String Caption = "Caption";
            public static readonly String CurrentRefreshRate = "CurrentRefreshRate";
            public static readonly String DriverDate = "DriverDate";
            public static readonly String DriverVersion = "DriverVersion";
            public static readonly String MaxRefreshRate = "MaxRefreshRate";
            public static readonly String MinRefreshRate = "MinRefreshRate";
            public static readonly String VideoProcessor = "VideoProcessor";
            public static readonly String VideoModeDescription = "VideoModeDescription";
        }

        public static class OS
        {
            public static readonly String Query = "select * from  Win32_OperatingSystem";
            public static readonly String Caption = "Caption";
            public static readonly String Architecture = "OSArchitecture";
            public static readonly String BuildNumber = "BuildNumber";
            public static readonly String Version = "Version";
            public static readonly String SerialNumber = "SerialNumber";
            public static readonly String LastBootUpTime = "LastBootUpTime";
            public static readonly String CountryCode = "CountryCode";
            public static readonly String CurrentTimeZone = "CurrentTimeZone";
            public static readonly String MUILanguages = "MUILanguages";
            public static readonly String Language = "OSLanguage";
            public static readonly String InstallDate = "InstallDate";
        }
    }
}
