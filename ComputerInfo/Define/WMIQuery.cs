using System;

namespace ComputerInfo.Define
{
    public class WMIQuery
    {
        //CPU WMI
        public static String WMI_CPU = "select * from  Win32_Processor";
        public static String WMI_CPU_NAME = "Name";
        public static String WMI_CPU_MAX_CLOCK = "MaxClockSpeed";
        public static String WMI_CPU_VOLTAGE = "CurrentVoltage";
        public static String WMI_CPU_L2CACHE_SIZE = "L2CacheSize";
        public static String WMI_CPU_L3CACHE_SIZE = "L3CacheSize";
        public static String WMI_CPU_CORE_COUNT = "NumberOfCores";
        public static String WMI_CPU_THREAD_COUNT = "ThreadCount";
        //BIOS WMI
        public static String REG_BIOS = @"HARDWARE\DESCRIPTION\System\BIOS";
        public static String REG_BIOS_BASE_MANUFACTURER = "BaseBoardManufacturer";
        public static String REG_BIOS_BASE_PRODUCT = "BaseBoardProduct";
        public static String REG_BIOS_BASE_VERSION = "BaseBoardVersion";
        public static String REG_BIOS_RELEASE_DATE = "BIOSReleaseDate";
        public static String REG_BIOS_VERSION = "BIOSVersion";
        public static String REG_BIOS_VENDOR = "BIOSVendor";
        public static String REG_BIOS_SYSTEM_PRODUCTNAME = "SystemProductName";
        public static String REG_BIOS_SYSTEM_MANUFACTURER = "SystemManufacturer";
        public static String REG_BIOS_SYSTEM_VERSION = "SystemVersion";
        //MEMORY WMI
        public static String WMI_RAM = "select * from  Win32_PhysicalMemory";
        public static String WMI_RAM_SPEED = "Speed";
        public static String WMI_RAM_VOLTAGE = "ConfiguredVoltage";
        public static String WMI_RAM_MANUFACTURER = "Manufacturer";
        //DISK WMI
        public static String WMI_DISK = "select * from  Win32_DiskDrive";
        public static String WMI_DISK_LOGICAL = "select * from  Win32_LogicalDisk";
        /*//DISK'S MORE INFO WMI
        public static String WMI_DISK_MORE_INFO_DISK = "select * from  Win32_DiskDrive";
        public static String WMI_DISK_MORE_INFO_LOGICAL_DISK = "select * from  Win32_LogicalDisk";
        public static String WMI_DISK_MORE_INFO_PARTIITION = "select * from  Win32_LogicalDiskToPartition";
        public static String WMI_DISK_MORE_INFO_CAPTION = "Caption";
        public static String WMI_DISK_MORE_INFO_DEVICEID = "DeviceID";
        public static String WMI_DISK_MORE_INFO_MODEL = "Model";
        public static String WMI_DISK_MORE_INFO_FILESYSTEM = "FileSystem";
        public static String WMI_DISK_MORE_INFO_VOLUMENAME = "VolumeName";
        public static String WMI_DISK_MORE_INFO_SIZE = "Size";
        public static String WMI_DISK_MORE_INFO_FREESPACE = "FreeSpace";
        public static String WMI_DISK_MORE_INFO_STATUS = "Status";
        public static String WMI_DISK_MORE_INFO_SYSTEMNAME = "SystemName";
        public static String WMI_DISK_MORE_INFO_NAME = "Name";
        public static String WMI_DISK_MORE_INFO_SERIALNUMBER = "SerialNumber";
        public static String WMI_DISK_MORE_INFO_VOLUMESERIALNUMBER = "VolumeSerialNumber";
        public static String WMI_DISK_MORE_INFO_SIGNATURE = "Signature";*/
        //GPU WMI
        public static String WMI_GPU = "select * from  Win32_VideoController";
        public static String WMI_GPU_ADAPTER_COMPATIABILITY = "AdapterCompatibility";//Company name
        public static String WMI_GPU_ADAPTER_RAM = "AdapterRAM";
        public static String WMI_GPU_CAPTION = "Caption";//Full name
        public static String WMI_GPU_CURRENT_REFRESH_RATE = "CurrentRefreshRate";
        public static String WMI_GPU_DRIVER_DATE = "DriverDate";
        public static String WMI_GPU_DRIVER_VERSION = "DriverVersion";
        public static String WMI_GPU_MAX_REFRESH_RATE = "MaxRefreshRate";
        public static String WMI_GPU_MIN_REFRESH_RATE = "MinRefreshRate";
        public static String WMI_GPU_VIDEO_PROCESSOR = "VideoProcessor";//Get graphic card name that except company name
        public static String WMI_GPU_VIDEO_MODE_DESCRIPTION = "VideoModeDescription";
        //OS WMI
        public static String WMI_OS = "select * from  Win32_OperatingSystem";
        public static String WMI_OS_NAME = "Caption";
        public static String WMI_OS_ARCHITECTURE = "OSArchitecture";
        public static String WMI_OS_BUILD_NUMBER = "BuildNumber";
        public static String WMI_OS_VERSION = "Version";
        public static String WMI_OS_SERIALNUMBER = "SerialNumber";
        public static String WMI_OS_LASTBOOTUPTIME = "LastBootUpTime";
        public static String WMI_OS_CONTRY_CODE = "CountryCode";
        public static String WMI_OS_CURRENT_TIME_ZONE = "CurrentTimeZone";
        public static String WMI_OS_MUI_LANGUAGES = "MUILanguages";
        public static String WMI_OS_LANGUAGE = "OSLanguage";
        public static String WMI_OS_INSTALL_DATE = "InstallDate";
       
    }
}
