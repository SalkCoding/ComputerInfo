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
            public static readonly String Query = "select * from  Win32_DiskDrive";
            public static readonly String d = "select * from  Win32_LogicalDisk";

            public static readonly String WMI_DISK_MORE_INFO_DISK = "select * from  Win32_DiskDrive";
            public static readonly String WMI_DISK_MORE_INFO_LOGICAL_DISK = "select * from  Win32_LogicalDisk";
            public static readonly String WMI_DISK_MORE_INFO_PARTIITION = "select * from  Win32_LogicalDiskToPartition";
            public static readonly String WMI_DISK_MORE_INFO_CAPTION = "Caption";
            public static readonly String WMI_DISK_MORE_INFO_DEVICEID = "DeviceID";
            public static readonly String WMI_DISK_MORE_INFO_MODEL = "Model";
            public static readonly String WMI_DISK_MORE_INFO_FILESYSTEM = "FileSystem";
            public static readonly String WMI_DISK_MORE_INFO_VOLUMENAME = "VolumeName";
            public static readonly String WMI_DISK_MORE_INFO_SIZE = "Size";
            public static readonly String WMI_DISK_MORE_INFO_FREESPACE = "FreeSpace";
            public static readonly String WMI_DISK_MORE_INFO_STATUS = "Status";
            public static readonly String WMI_DISK_MORE_INFO_SYSTEMNAME = "SystemName";
            public static readonly String WMI_DISK_MORE_INFO_NAME = "Name";
            public static readonly String WMI_DISK_MORE_INFO_SERIALNUMBER = "SerialNumber";
            public static readonly String WMI_DISK_MORE_INFO_VOLUMESERIALNUMBER = "VolumeSerialNumber";
            public static readonly String WMI_DISK_MORE_INFO_SIGNATURE = "Signature";
        }

        public static class GPU
        {
            public static String Query = "select * from  Win32_VideoController";
            public static String AdapterCompatibility = "AdapterCompatibility";
            public static String AdapterRAM = "AdapterRAM";
            public static String Caption = "Caption";
            public static String CurrentRefreshRate = "CurrentRefreshRate";
            public static String DriverDate = "DriverDate";
            public static String DriverVersion = "DriverVersion";
            public static String MaxRefreshRate = "MaxRefreshRate";
            public static String MinRefreshRate = "MinRefreshRate";
            public static String VideoProcessor = "VideoProcessor";
            public static String VideoModeDescription = "VideoModeDescription";
        }

        public static class OS
        {
            public static String Query = "select * from  Win32_OperatingSystem";
            public static String Caption = "Caption";
            public static String Architecture = "OSArchitecture";
            public static String BuildNumber = "BuildNumber";
            public static String Version = "Version";
            public static String SerialNumber = "SerialNumber";
            public static String LastBootUpTime = "LastBootUpTime";
            public static String CountryCode = "CountryCode";
            public static String CurrentTimeZone = "CurrentTimeZone";
            public static String MUILanguages = "MUILanguages";
            public static String Language = "OSLanguage";
            public static String InstallDate = "InstallDate";
        }
    }
}
