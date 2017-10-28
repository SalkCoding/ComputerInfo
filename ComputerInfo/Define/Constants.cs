using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.Define
{
    public class Constants
    {
        //Logo URL
        public static String MSI_LOGO = @"https://kr.msi.com/images/msiLogo_2017.png";
        public static String ASUS_LOGO = @"https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/ASUS_Logo.svg/300px-ASUS_Logo.svg.png";
        public static String GIGABYTE_LOGO = @"https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Gigabyte_logo.svg/300px-Gigabyte_logo.svg.png";
        public static String ASROCK_LOGO = @"https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/AsrockLogo.png/220px-AsrockLogo.png";
        public static String INTEL_LOGO = @"https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Intel-logo.svg/95px-Intel-logo.svg.png";
        public static String BIOSTAR_LOGO = @"http://www.biostar.com.tw/app/en/images/logo/logo.png";
        public static String DELL_LOGO = @"http://i.dell.com/images/global/brand/ui/logo-wt-bl.png";
        public static String HP_LOGO = @"http://www.www8-hp.com/kr/ko/images/i/hpi/header-footer/caas-hf-v3.2/hpi-hp-logo-pr.gif";
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
        //DISK WMI
        public static String WMI_DISK = "select * from  Win32_DiskDrive";
        public static String WMI_DISK_MODEL = "Model";
        public static String WMI_DISK_SERIAL_NUMBER = "SerialNumber";
        public static String WMI_DISK_INDEX = "Index";
        public static String WMI_DISK_LOGICAL = "select * from  Win32_LogicalDisk";
        public static String WMI_DISK_LOGICAL_CAPTION = "Caption";
        public static String WMI_DISK_LOGICAL_VOLUME_NAME = "VolumeName";
        public static String WMI_DISK_LOGICAL_SERIAL_NUMBER = "VolumeSerialNumber";
        //GPU WMI

        //OTHER WMI

        //define
        public static Int32 DISK_MAX_COUNT = 6;

    }
}
