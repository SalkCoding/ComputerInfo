using ComputerInfo.Source_code.tabPage;
using ComputerInfo.WMI;
using MetroSuite;
using System;
using System.Management;

namespace ComputerInfo.TabPage
{
    internal class OSTabPage : ITabPage
    {
        private readonly OS os;

        private readonly MetroLabel lblOsCaption;
        private readonly MetroLabel lblOsArchitecture;
        private readonly MetroLabel lblOsBuildNumber;
        private readonly MetroLabel lblOsVersion;
        private readonly MetroLabel lblOsSerialNumber;
        private readonly MetroLabel lblOsCountryCode;
        private readonly MetroLabel lblOsCurrentTimeZone;
        private readonly MetroLabel lblOsMuiLanguagesCode;
        private readonly MetroLabel lblOsLanguage;
        private readonly MetroLabel lblOsInstallTime;
        private readonly MetroLabel lblOsLastBootUpTime;

        public OSTabPage(
            OS os,
            MetroLabel lblOsCaption,
            MetroLabel lblOsArchitecture,
            MetroLabel lblOsBuildNumber,
            MetroLabel lblOsVersion,
            MetroLabel lblOsSerialNumber,
            MetroLabel lblOsCountryCode,
            MetroLabel lblOsCurrentTimeZone,
            MetroLabel lblOsMuiLanguagesCode,
            MetroLabel lblOsLanguage,
            MetroLabel lblOsInstallTime,
            MetroLabel lblOsLastBootUpTime
            )
        {
            this.os = os;
            this.lblOsCaption = lblOsCaption;
            this.lblOsArchitecture = lblOsArchitecture;
            this.lblOsBuildNumber = lblOsBuildNumber;
            this.lblOsVersion = lblOsVersion;
            this.lblOsSerialNumber = lblOsSerialNumber;
            this.lblOsCountryCode = lblOsCountryCode;
            this.lblOsCurrentTimeZone = lblOsCurrentTimeZone;
            this.lblOsMuiLanguagesCode = lblOsMuiLanguagesCode;
            this.lblOsLanguage = lblOsLanguage;
            this.lblOsInstallTime = lblOsInstallTime;
            this.lblOsLastBootUpTime = lblOsLastBootUpTime;
        }

        public void update()
        {
            lblOsCaption.Text = os.Caption;
            lblOsArchitecture.Text = os.Architecture;
            lblOsBuildNumber.Text = os.BuildNumber;
            lblOsVersion.Text = os.Version;
            lblOsSerialNumber.Text = os.SerialNumber;
            lblOsCountryCode.Text = os.CountryCode;
            lblOsCurrentTimeZone.Text = os.CurrentTimeZone;
            lblOsMuiLanguagesCode.Text = os.MUILanguages;
            lblOsLanguage.Text = os.Language;
            lblOsInstallTime.Text = os.InstallTime.ToString();
            DateTime time = ManagementDateTimeConverter.ToDateTime(os.LastBootUpTime);
            lblOsLastBootUpTime.Text = time.ToString();
        }
    }
}
