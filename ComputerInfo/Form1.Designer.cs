namespace ComputerInfo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrGraphUpdater = new System.Windows.Forms.Timer(this.components);
            this.OSTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel47 = new MetroSuite.MetroLabel();
            this.metroLabel49 = new MetroSuite.MetroLabel();
            this.lblOsLastBootUpTime = new MetroSuite.MetroLabel();
            this.lblOsInstallTime = new MetroSuite.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel24 = new MetroSuite.MetroLabel();
            this.lblOsLanguage = new MetroSuite.MetroLabel();
            this.metroLabel31 = new MetroSuite.MetroLabel();
            this.metroLabel34 = new MetroSuite.MetroLabel();
            this.metroLabel36 = new MetroSuite.MetroLabel();
            this.lblOsMuiLanguagesCode = new MetroSuite.MetroLabel();
            this.lblOsCurrentTimeZone = new MetroSuite.MetroLabel();
            this.lblOsContryCode = new MetroSuite.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel16 = new MetroSuite.MetroLabel();
            this.metroLabel20 = new MetroSuite.MetroLabel();
            this.lblOsSerialNumber = new MetroSuite.MetroLabel();
            this.metroLabel58 = new MetroSuite.MetroLabel();
            this.metroLabel59 = new MetroSuite.MetroLabel();
            this.metroLabel60 = new MetroSuite.MetroLabel();
            this.lblOsVersion = new MetroSuite.MetroLabel();
            this.lblOsBuildNumber = new MetroSuite.MetroLabel();
            this.lblOsArchitecture = new MetroSuite.MetroLabel();
            this.lblOsCaption = new MetroSuite.MetroLabel();
            this.metroLabel32 = new MetroSuite.MetroLabel();
            this.GPUTab = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.metroLabel43 = new MetroSuite.MetroLabel();
            this.metroLabel45 = new MetroSuite.MetroLabel();
            this.lblGpuDriverVersion = new MetroSuite.MetroLabel();
            this.lblGpuDriverDate = new MetroSuite.MetroLabel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.metroLabel39 = new MetroSuite.MetroLabel();
            this.metroLabel42 = new MetroSuite.MetroLabel();
            this.lblMonitorCurrentResolution = new MetroSuite.MetroLabel();
            this.metroLabel41 = new MetroSuite.MetroLabel();
            this.lblMonitorCurrentRefreshRate = new MetroSuite.MetroLabel();
            this.metroLabel40 = new MetroSuite.MetroLabel();
            this.lblMonitorMinRefreshRate = new MetroSuite.MetroLabel();
            this.lblMonitorMaxRefreshRate = new MetroSuite.MetroLabel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.metroLabel46 = new MetroSuite.MetroLabel();
            this.metroLabel44 = new MetroSuite.MetroLabel();
            this.metroLabel25 = new MetroSuite.MetroLabel();
            this.metroLabel38 = new MetroSuite.MetroLabel();
            this.lblGpuMemorySize = new MetroSuite.MetroLabel();
            this.lblGpuManufacturer = new MetroSuite.MetroLabel();
            this.lblGpuVideoProcessName = new MetroSuite.MetroLabel();
            this.lblGpuCaption = new MetroSuite.MetroLabel();
            this.DiskTab = new System.Windows.Forms.TabPage();
            this.metroLabel51 = new MetroSuite.MetroLabel();
            this.btnDetailStorage = new MetroSuite.MetroNavigationButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.Disk_H_Status = new MetroSuite.MetroLabel();
            this.Disk_G_Status = new MetroSuite.MetroLabel();
            this.Disk_F_Status = new MetroSuite.MetroLabel();
            this.Disk_E_Status = new MetroSuite.MetroLabel();
            this.Disk_D_Status = new MetroSuite.MetroLabel();
            this.Disk_D_Caption = new MetroSuite.MetroLabel();
            this.gcpCUsage = new GChartLib.GCircularProgress();
            this.gcpDUsage = new GChartLib.GCircularProgress();
            this.gcpEUsage = new GChartLib.GCircularProgress();
            this.gcpFUsage = new GChartLib.GCircularProgress();
            this.gcpGUsage = new GChartLib.GCircularProgress();
            this.Disk_C_Caption = new MetroSuite.MetroLabel();
            this.Disk_C_Status = new MetroSuite.MetroLabel();
            this.Disk_H_Caption = new MetroSuite.MetroLabel();
            this.Disk_G_Caption = new MetroSuite.MetroLabel();
            this.Disk_E_Caption = new MetroSuite.MetroLabel();
            this.Disk_F_Caption = new MetroSuite.MetroLabel();
            this.gcpHUsage = new GChartLib.GCircularProgress();
            this.metroLabel23 = new MetroSuite.MetroLabel();
            this.btnStorageRefresh = new MetroSuite.MetroButton();
            this.MemoryTab = new System.Windows.Forms.TabPage();
            this.lblMemorySummary = new MetroSuite.MetroLabel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.metroLabel48 = new MetroSuite.MetroLabel();
            this.metroLabel27 = new MetroSuite.MetroLabel();
            this.metroLabel28 = new MetroSuite.MetroLabel();
            this.metroLabel29 = new MetroSuite.MetroLabel();
            this.metroLabel30 = new MetroSuite.MetroLabel();
            this.lblMemoryManufacturer = new MetroSuite.MetroLabel();
            this.lblMemorySpeed = new MetroSuite.MetroLabel();
            this.lblMemoryVoltage = new MetroSuite.MetroLabel();
            this.lblVirtualMemorySize = new MetroSuite.MetroLabel();
            this.lblMemoryPhysicalSize = new MetroSuite.MetroLabel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.metroLabel15 = new MetroSuite.MetroLabel();
            this.metroLabel26 = new MetroSuite.MetroLabel();
            this.lblVirtualMemoryUsed = new MetroSuite.MetroLabel();
            this.gcpPhysicalMemoryUsage = new GChartLib.GCircularProgress();
            this.lblPhysicalMemoryUsed = new MetroSuite.MetroLabel();
            this.gcpVirtualMemoryUsage = new GChartLib.GCircularProgress();
            this.cboMemoryRefreshSpeed = new MetroSuite.MetroComboBox();
            this.metroLabel14 = new MetroSuite.MetroLabel();
            this.metroLabel21 = new MetroSuite.MetroLabel();
            this.swMemoryRefresh = new MetroSuite.MetroSwitch();
            this.trkMemory = new MetroSuite.MetroTracker();
            this.MotherBoardTab = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.metroLabel13 = new MetroSuite.MetroLabel();
            this.metroLabel11 = new MetroSuite.MetroLabel();
            this.lblMotherboardSystemManufacturer = new MetroSuite.MetroLabel();
            this.lblMotherboardSystemVersion = new MetroSuite.MetroLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.metroLabel19 = new MetroSuite.MetroLabel();
            this.metroLabel18 = new MetroSuite.MetroLabel();
            this.metroLabel17 = new MetroSuite.MetroLabel();
            this.lblBiosVendor = new MetroSuite.MetroLabel();
            this.lblBiosReleaseDate = new MetroSuite.MetroLabel();
            this.lblBiosVersion = new MetroSuite.MetroLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.metroLabel22 = new MetroSuite.MetroLabel();
            this.metroLabel33 = new MetroSuite.MetroLabel();
            this.metroLabel57 = new MetroSuite.MetroLabel();
            this.metroLabel8 = new MetroSuite.MetroLabel();
            this.lblMotherboardSystemProductName = new MetroSuite.MetroLabel();
            this.lblMotherboardManufacturer = new MetroSuite.MetroLabel();
            this.lblMotherboardProduct = new MetroSuite.MetroLabel();
            this.lblMotherboardVersion = new MetroSuite.MetroLabel();
            this.CPUTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroSuite.MetroLabel();
            this.gcpCpuUsage = new GChartLib.GCircularProgress();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroSuite.MetroLabel();
            this.metroLabel6 = new MetroSuite.MetroLabel();
            this.lblCpuVoltage = new MetroSuite.MetroLabel();
            this.lblCpuThread = new MetroSuite.MetroLabel();
            this.lblCpuL2Cache = new MetroSuite.MetroLabel();
            this.metroLabel4 = new MetroSuite.MetroLabel();
            this.metroLabel7 = new MetroSuite.MetroLabel();
            this.lblCpuL3Cache = new MetroSuite.MetroLabel();
            this.metroLabel2 = new MetroSuite.MetroLabel();
            this.lblCpuClock = new MetroSuite.MetroLabel();
            this.metroLabel9 = new MetroSuite.MetroLabel();
            this.lblCpuCore = new MetroSuite.MetroLabel();
            this.cboCpuRefreshSpeed = new MetroSuite.MetroComboBox();
            this.metroLabel10 = new MetroSuite.MetroLabel();
            this.lblCpuName = new MetroSuite.MetroLabel();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.swCpuRefresh = new MetroSuite.MetroSwitch();
            this.trkCpu = new MetroSuite.MetroTracker();
            this.metroTabControl1 = new MetroSuite.MetroTabControl();
            this.OSTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GPUTab.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.DiskTab.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.MemoryTab.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.MotherBoardTab.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.CPUTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrGraphUpdater
            // 
            this.tmrGraphUpdater.Interval = 1000;
            this.tmrGraphUpdater.Tick += new System.EventHandler(this.GraphUpdater_Tick);
            // 
            // OSTab
            // 
            this.OSTab.Controls.Add(this.groupBox3);
            this.OSTab.Controls.Add(this.groupBox2);
            this.OSTab.Controls.Add(this.groupBox1);
            this.OSTab.Controls.Add(this.metroLabel32);
            this.OSTab.Location = new System.Drawing.Point(124, 4);
            this.OSTab.Name = "OSTab";
            this.OSTab.Padding = new System.Windows.Forms.Padding(3);
            this.OSTab.Size = new System.Drawing.Size(904, 566);
            this.OSTab.TabIndex = 6;
            this.OSTab.Text = "Operating System";
            this.OSTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel47);
            this.groupBox3.Controls.Add(this.metroLabel49);
            this.groupBox3.Controls.Add(this.lblOsLastBootUpTime);
            this.groupBox3.Controls.Add(this.lblOsInstallTime);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.Location = new System.Drawing.Point(6, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(892, 84);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Another information";
            // 
            // metroLabel47
            // 
            this.metroLabel47.AutoSize = true;
            this.metroLabel47.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel47.Location = new System.Drawing.Point(6, 25);
            this.metroLabel47.Name = "metroLabel47";
            this.metroLabel47.Size = new System.Drawing.Size(93, 21);
            this.metroLabel47.TabIndex = 46;
            this.metroLabel47.Text = "Install time :";
            // 
            // metroLabel49
            // 
            this.metroLabel49.AutoSize = true;
            this.metroLabel49.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel49.Location = new System.Drawing.Point(6, 50);
            this.metroLabel49.Name = "metroLabel49";
            this.metroLabel49.Size = new System.Drawing.Size(138, 21);
            this.metroLabel49.TabIndex = 47;
            this.metroLabel49.Text = "Last boot up time :";
            // 
            // lblOsLastBootUpTime
            // 
            this.lblOsLastBootUpTime.AutoSize = true;
            this.lblOsLastBootUpTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsLastBootUpTime.Location = new System.Drawing.Point(150, 50);
            this.lblOsLastBootUpTime.Name = "lblOsLastBootUpTime";
            this.lblOsLastBootUpTime.Size = new System.Drawing.Size(68, 21);
            this.lblOsLastBootUpTime.TabIndex = 35;
            this.lblOsLastBootUpTime.Text = "Unknow";
            // 
            // lblOsInstallTime
            // 
            this.lblOsInstallTime.AutoSize = true;
            this.lblOsInstallTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsInstallTime.Location = new System.Drawing.Point(105, 25);
            this.lblOsInstallTime.Name = "lblOsInstallTime";
            this.lblOsInstallTime.Size = new System.Drawing.Size(68, 21);
            this.lblOsInstallTime.TabIndex = 32;
            this.lblOsInstallTime.Text = "Unknow";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel24);
            this.groupBox2.Controls.Add(this.lblOsLanguage);
            this.groupBox2.Controls.Add(this.metroLabel31);
            this.groupBox2.Controls.Add(this.metroLabel34);
            this.groupBox2.Controls.Add(this.metroLabel36);
            this.groupBox2.Controls.Add(this.lblOsMuiLanguagesCode);
            this.groupBox2.Controls.Add(this.lblOsCurrentTimeZone);
            this.groupBox2.Controls.Add(this.lblOsContryCode);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(6, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 132);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information of Codes";
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel24.Location = new System.Drawing.Point(6, 100);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(147, 21);
            this.metroLabel24.TabIndex = 49;
            this.metroLabel24.Text = "OS Language code :";
            // 
            // lblOsLanguage
            // 
            this.lblOsLanguage.AutoSize = true;
            this.lblOsLanguage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsLanguage.Location = new System.Drawing.Point(159, 100);
            this.lblOsLanguage.Name = "lblOsLanguage";
            this.lblOsLanguage.Size = new System.Drawing.Size(68, 21);
            this.lblOsLanguage.TabIndex = 39;
            this.lblOsLanguage.Text = "Unknow";
            // 
            // metroLabel31
            // 
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel31.Location = new System.Drawing.Point(6, 75);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(162, 21);
            this.metroLabel31.TabIndex = 48;
            this.metroLabel31.Text = "MUI Languages code :";
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel34.Location = new System.Drawing.Point(6, 25);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(101, 21);
            this.metroLabel34.TabIndex = 46;
            this.metroLabel34.Text = "Contry code :";
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel36.Location = new System.Drawing.Point(6, 50);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(179, 21);
            this.metroLabel36.TabIndex = 47;
            this.metroLabel36.Text = "Current time zone code :";
            // 
            // lblOsMuiLanguagesCode
            // 
            this.lblOsMuiLanguagesCode.AutoSize = true;
            this.lblOsMuiLanguagesCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsMuiLanguagesCode.Location = new System.Drawing.Point(174, 75);
            this.lblOsMuiLanguagesCode.Name = "lblOsMuiLanguagesCode";
            this.lblOsMuiLanguagesCode.Size = new System.Drawing.Size(68, 21);
            this.lblOsMuiLanguagesCode.TabIndex = 37;
            this.lblOsMuiLanguagesCode.Text = "Unknow";
            // 
            // lblOsCurrentTimeZone
            // 
            this.lblOsCurrentTimeZone.AutoSize = true;
            this.lblOsCurrentTimeZone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsCurrentTimeZone.Location = new System.Drawing.Point(191, 50);
            this.lblOsCurrentTimeZone.Name = "lblOsCurrentTimeZone";
            this.lblOsCurrentTimeZone.Size = new System.Drawing.Size(68, 21);
            this.lblOsCurrentTimeZone.TabIndex = 35;
            this.lblOsCurrentTimeZone.Text = "Unknow";
            // 
            // lblOsContryCode
            // 
            this.lblOsContryCode.AutoSize = true;
            this.lblOsContryCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsContryCode.Location = new System.Drawing.Point(113, 25);
            this.lblOsContryCode.Name = "lblOsContryCode";
            this.lblOsContryCode.Size = new System.Drawing.Size(68, 21);
            this.lblOsContryCode.TabIndex = 32;
            this.lblOsContryCode.Text = "Unknow";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.metroLabel20);
            this.groupBox1.Controls.Add(this.lblOsSerialNumber);
            this.groupBox1.Controls.Add(this.metroLabel58);
            this.groupBox1.Controls.Add(this.metroLabel59);
            this.groupBox1.Controls.Add(this.metroLabel60);
            this.groupBox1.Controls.Add(this.lblOsVersion);
            this.groupBox1.Controls.Add(this.lblOsBuildNumber);
            this.groupBox1.Controls.Add(this.lblOsArchitecture);
            this.groupBox1.Controls.Add(this.lblOsCaption);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 156);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic information of OS";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel16.Location = new System.Drawing.Point(9, 125);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(115, 21);
            this.metroLabel16.TabIndex = 50;
            this.metroLabel16.Text = "Serial number :";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel20.Location = new System.Drawing.Point(9, 100);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(69, 21);
            this.metroLabel20.TabIndex = 49;
            this.metroLabel20.Text = "Version :";
            // 
            // lblOsSerialNumber
            // 
            this.lblOsSerialNumber.AutoSize = true;
            this.lblOsSerialNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsSerialNumber.Location = new System.Drawing.Point(130, 125);
            this.lblOsSerialNumber.Name = "lblOsSerialNumber";
            this.lblOsSerialNumber.Size = new System.Drawing.Size(68, 21);
            this.lblOsSerialNumber.TabIndex = 41;
            this.lblOsSerialNumber.Text = "Unknow";
            // 
            // metroLabel58
            // 
            this.metroLabel58.AutoSize = true;
            this.metroLabel58.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel58.Location = new System.Drawing.Point(9, 75);
            this.metroLabel58.Name = "metroLabel58";
            this.metroLabel58.Size = new System.Drawing.Size(111, 21);
            this.metroLabel58.TabIndex = 48;
            this.metroLabel58.Text = "Build number :";
            // 
            // metroLabel59
            // 
            this.metroLabel59.AutoSize = true;
            this.metroLabel59.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel59.Location = new System.Drawing.Point(6, 25);
            this.metroLabel59.Name = "metroLabel59";
            this.metroLabel59.Size = new System.Drawing.Size(84, 21);
            this.metroLabel59.TabIndex = 46;
            this.metroLabel59.Text = "OS Name :";
            // 
            // metroLabel60
            // 
            this.metroLabel60.AutoSize = true;
            this.metroLabel60.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel60.Location = new System.Drawing.Point(9, 50);
            this.metroLabel60.Name = "metroLabel60";
            this.metroLabel60.Size = new System.Drawing.Size(101, 21);
            this.metroLabel60.TabIndex = 47;
            this.metroLabel60.Text = "Architecture :";
            // 
            // lblOsVersion
            // 
            this.lblOsVersion.AutoSize = true;
            this.lblOsVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsVersion.Location = new System.Drawing.Point(84, 100);
            this.lblOsVersion.Name = "lblOsVersion";
            this.lblOsVersion.Size = new System.Drawing.Size(68, 21);
            this.lblOsVersion.TabIndex = 39;
            this.lblOsVersion.Text = "Unknow";
            // 
            // lblOsBuildNumber
            // 
            this.lblOsBuildNumber.AutoSize = true;
            this.lblOsBuildNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsBuildNumber.Location = new System.Drawing.Point(126, 75);
            this.lblOsBuildNumber.Name = "lblOsBuildNumber";
            this.lblOsBuildNumber.Size = new System.Drawing.Size(68, 21);
            this.lblOsBuildNumber.TabIndex = 37;
            this.lblOsBuildNumber.Text = "Unknow";
            // 
            // lblOsArchitecture
            // 
            this.lblOsArchitecture.AutoSize = true;
            this.lblOsArchitecture.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsArchitecture.Location = new System.Drawing.Point(116, 50);
            this.lblOsArchitecture.Name = "lblOsArchitecture";
            this.lblOsArchitecture.Size = new System.Drawing.Size(68, 21);
            this.lblOsArchitecture.TabIndex = 35;
            this.lblOsArchitecture.Text = "Unknow";
            // 
            // lblOsCaption
            // 
            this.lblOsCaption.AutoSize = true;
            this.lblOsCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOsCaption.Location = new System.Drawing.Point(96, 25);
            this.lblOsCaption.Name = "lblOsCaption";
            this.lblOsCaption.Size = new System.Drawing.Size(68, 21);
            this.lblOsCaption.TabIndex = 32;
            this.lblOsCaption.Text = "Unknow";
            // 
            // metroLabel32
            // 
            this.metroLabel32.AutoSize = true;
            this.metroLabel32.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel32.Location = new System.Drawing.Point(6, 82);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(0, 21);
            this.metroLabel32.TabIndex = 33;
            // 
            // GPUTab
            // 
            this.GPUTab.Controls.Add(this.groupBox14);
            this.GPUTab.Controls.Add(this.groupBox13);
            this.GPUTab.Controls.Add(this.groupBox12);
            this.GPUTab.Location = new System.Drawing.Point(124, 4);
            this.GPUTab.Name = "GPUTab";
            this.GPUTab.Size = new System.Drawing.Size(904, 566);
            this.GPUTab.TabIndex = 3;
            this.GPUTab.Text = "GPU";
            this.GPUTab.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.metroLabel43);
            this.groupBox14.Controls.Add(this.metroLabel45);
            this.groupBox14.Controls.Add(this.lblGpuDriverVersion);
            this.groupBox14.Controls.Add(this.lblGpuDriverDate);
            this.groupBox14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox14.Location = new System.Drawing.Point(3, 387);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(898, 176);
            this.groupBox14.TabIndex = 44;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Information of GPU driver";
            // 
            // metroLabel43
            // 
            this.metroLabel43.AutoSize = true;
            this.metroLabel43.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel43.Location = new System.Drawing.Point(6, 30);
            this.metroLabel43.Name = "metroLabel43";
            this.metroLabel43.Size = new System.Drawing.Size(115, 21);
            this.metroLabel43.TabIndex = 38;
            this.metroLabel43.Text = "Driver version :";
            // 
            // metroLabel45
            // 
            this.metroLabel45.AutoSize = true;
            this.metroLabel45.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel45.Location = new System.Drawing.Point(6, 70);
            this.metroLabel45.Name = "metroLabel45";
            this.metroLabel45.Size = new System.Drawing.Size(96, 21);
            this.metroLabel45.TabIndex = 37;
            this.metroLabel45.Text = "Driver Date :";
            // 
            // lblGpuDriverVersion
            // 
            this.lblGpuDriverVersion.AutoSize = true;
            this.lblGpuDriverVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGpuDriverVersion.Location = new System.Drawing.Point(127, 30);
            this.lblGpuDriverVersion.Name = "lblGpuDriverVersion";
            this.lblGpuDriverVersion.Size = new System.Drawing.Size(68, 21);
            this.lblGpuDriverVersion.TabIndex = 33;
            this.lblGpuDriverVersion.Text = "Unknow";
            // 
            // lblGpuDriverDate
            // 
            this.lblGpuDriverDate.AutoSize = true;
            this.lblGpuDriverDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGpuDriverDate.Location = new System.Drawing.Point(108, 70);
            this.lblGpuDriverDate.Name = "lblGpuDriverDate";
            this.lblGpuDriverDate.Size = new System.Drawing.Size(68, 21);
            this.lblGpuDriverDate.TabIndex = 36;
            this.lblGpuDriverDate.Text = "Unknow";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.metroLabel39);
            this.groupBox13.Controls.Add(this.metroLabel42);
            this.groupBox13.Controls.Add(this.lblMonitorCurrentResolution);
            this.groupBox13.Controls.Add(this.metroLabel41);
            this.groupBox13.Controls.Add(this.lblMonitorCurrentRefreshRate);
            this.groupBox13.Controls.Add(this.metroLabel40);
            this.groupBox13.Controls.Add(this.lblMonitorMinRefreshRate);
            this.groupBox13.Controls.Add(this.lblMonitorMaxRefreshRate);
            this.groupBox13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox13.Location = new System.Drawing.Point(480, 205);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(421, 176);
            this.groupBox13.TabIndex = 43;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Information of Monitor";
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel39.Location = new System.Drawing.Point(6, 25);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(154, 21);
            this.metroLabel39.TabIndex = 42;
            this.metroLabel39.Text = "Current refresh rate :";
            // 
            // metroLabel42
            // 
            this.metroLabel42.AutoSize = true;
            this.metroLabel42.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel42.Location = new System.Drawing.Point(6, 145);
            this.metroLabel42.Name = "metroLabel42";
            this.metroLabel42.Size = new System.Drawing.Size(144, 21);
            this.metroLabel42.TabIndex = 39;
            this.metroLabel42.Text = "Current resolution :";
            // 
            // lblMonitorCurrentResolution
            // 
            this.lblMonitorCurrentResolution.AutoSize = true;
            this.lblMonitorCurrentResolution.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMonitorCurrentResolution.Location = new System.Drawing.Point(156, 145);
            this.lblMonitorCurrentResolution.Name = "lblMonitorCurrentResolution";
            this.lblMonitorCurrentResolution.Size = new System.Drawing.Size(68, 21);
            this.lblMonitorCurrentResolution.TabIndex = 39;
            this.lblMonitorCurrentResolution.Text = "Unknow";
            // 
            // metroLabel41
            // 
            this.metroLabel41.AutoSize = true;
            this.metroLabel41.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel41.Location = new System.Drawing.Point(6, 105);
            this.metroLabel41.Name = "metroLabel41";
            this.metroLabel41.Size = new System.Drawing.Size(169, 21);
            this.metroLabel41.TabIndex = 40;
            this.metroLabel41.Text = "Minimum refresh rate :";
            // 
            // lblMonitorCurrentRefreshRate
            // 
            this.lblMonitorCurrentRefreshRate.AutoSize = true;
            this.lblMonitorCurrentRefreshRate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMonitorCurrentRefreshRate.Location = new System.Drawing.Point(166, 25);
            this.lblMonitorCurrentRefreshRate.Name = "lblMonitorCurrentRefreshRate";
            this.lblMonitorCurrentRefreshRate.Size = new System.Drawing.Size(68, 21);
            this.lblMonitorCurrentRefreshRate.TabIndex = 38;
            this.lblMonitorCurrentRefreshRate.Text = "Unknow";
            // 
            // metroLabel40
            // 
            this.metroLabel40.AutoSize = true;
            this.metroLabel40.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel40.Location = new System.Drawing.Point(6, 65);
            this.metroLabel40.Name = "metroLabel40";
            this.metroLabel40.Size = new System.Drawing.Size(171, 21);
            this.metroLabel40.TabIndex = 41;
            this.metroLabel40.Text = "Maximum refresh rate :";
            // 
            // lblMonitorMinRefreshRate
            // 
            this.lblMonitorMinRefreshRate.AutoSize = true;
            this.lblMonitorMinRefreshRate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMonitorMinRefreshRate.Location = new System.Drawing.Point(181, 105);
            this.lblMonitorMinRefreshRate.Name = "lblMonitorMinRefreshRate";
            this.lblMonitorMinRefreshRate.Size = new System.Drawing.Size(68, 21);
            this.lblMonitorMinRefreshRate.TabIndex = 34;
            this.lblMonitorMinRefreshRate.Text = "Unknow";
            // 
            // lblMonitorMaxRefreshRate
            // 
            this.lblMonitorMaxRefreshRate.AutoSize = true;
            this.lblMonitorMaxRefreshRate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMonitorMaxRefreshRate.Location = new System.Drawing.Point(183, 65);
            this.lblMonitorMaxRefreshRate.Name = "lblMonitorMaxRefreshRate";
            this.lblMonitorMaxRefreshRate.Size = new System.Drawing.Size(68, 21);
            this.lblMonitorMaxRefreshRate.TabIndex = 35;
            this.lblMonitorMaxRefreshRate.Text = "Unknow";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.metroLabel46);
            this.groupBox12.Controls.Add(this.metroLabel44);
            this.groupBox12.Controls.Add(this.metroLabel25);
            this.groupBox12.Controls.Add(this.metroLabel38);
            this.groupBox12.Controls.Add(this.lblGpuMemorySize);
            this.groupBox12.Controls.Add(this.lblGpuManufacturer);
            this.groupBox12.Controls.Add(this.lblGpuVideoProcessName);
            this.groupBox12.Controls.Add(this.lblGpuCaption);
            this.groupBox12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox12.Location = new System.Drawing.Point(3, 203);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(471, 178);
            this.groupBox12.TabIndex = 42;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Basic information of GPU";
            // 
            // metroLabel46
            // 
            this.metroLabel46.AutoSize = true;
            this.metroLabel46.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel46.Location = new System.Drawing.Point(6, 27);
            this.metroLabel46.Name = "metroLabel46";
            this.metroLabel46.Size = new System.Drawing.Size(111, 21);
            this.metroLabel46.TabIndex = 42;
            this.metroLabel46.Text = "Manufacturer :";
            // 
            // metroLabel44
            // 
            this.metroLabel44.AutoSize = true;
            this.metroLabel44.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel44.Location = new System.Drawing.Point(6, 67);
            this.metroLabel44.Name = "metroLabel44";
            this.metroLabel44.Size = new System.Drawing.Size(71, 21);
            this.metroLabel44.TabIndex = 43;
            this.metroLabel44.Text = "Caption :";
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel25.Location = new System.Drawing.Point(6, 147);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(106, 21);
            this.metroLabel25.TabIndex = 45;
            this.metroLabel25.Text = "Memory size :";
            // 
            // metroLabel38
            // 
            this.metroLabel38.AutoSize = true;
            this.metroLabel38.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel38.Location = new System.Drawing.Point(6, 107);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(172, 21);
            this.metroLabel38.TabIndex = 44;
            this.metroLabel38.Text = "Video processor name :";
            // 
            // lblGpuMemorySize
            // 
            this.lblGpuMemorySize.AutoSize = true;
            this.lblGpuMemorySize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGpuMemorySize.Location = new System.Drawing.Point(118, 147);
            this.lblGpuMemorySize.Name = "lblGpuMemorySize";
            this.lblGpuMemorySize.Size = new System.Drawing.Size(68, 21);
            this.lblGpuMemorySize.TabIndex = 41;
            this.lblGpuMemorySize.Text = "Unknow";
            // 
            // lblGpuManufacturer
            // 
            this.lblGpuManufacturer.AutoSize = true;
            this.lblGpuManufacturer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGpuManufacturer.Location = new System.Drawing.Point(127, 27);
            this.lblGpuManufacturer.Name = "lblGpuManufacturer";
            this.lblGpuManufacturer.Size = new System.Drawing.Size(68, 21);
            this.lblGpuManufacturer.TabIndex = 31;
            this.lblGpuManufacturer.Text = "Unknow";
            // 
            // lblGpuVideoProcessName
            // 
            this.lblGpuVideoProcessName.AutoSize = true;
            this.lblGpuVideoProcessName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGpuVideoProcessName.Location = new System.Drawing.Point(184, 107);
            this.lblGpuVideoProcessName.Name = "lblGpuVideoProcessName";
            this.lblGpuVideoProcessName.Size = new System.Drawing.Size(68, 21);
            this.lblGpuVideoProcessName.TabIndex = 32;
            this.lblGpuVideoProcessName.Text = "Unknow";
            // 
            // lblGpuCaption
            // 
            this.lblGpuCaption.AutoSize = true;
            this.lblGpuCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGpuCaption.Location = new System.Drawing.Point(83, 67);
            this.lblGpuCaption.Name = "lblGpuCaption";
            this.lblGpuCaption.Size = new System.Drawing.Size(68, 21);
            this.lblGpuCaption.TabIndex = 37;
            this.lblGpuCaption.Text = "Unknow";
            // 
            // DiskTab
            // 
            this.DiskTab.Controls.Add(this.metroLabel51);
            this.DiskTab.Controls.Add(this.btnDetailStorage);
            this.DiskTab.Controls.Add(this.groupBox11);
            this.DiskTab.Controls.Add(this.metroLabel23);
            this.DiskTab.Controls.Add(this.btnStorageRefresh);
            this.DiskTab.Location = new System.Drawing.Point(124, 4);
            this.DiskTab.Name = "DiskTab";
            this.DiskTab.Size = new System.Drawing.Size(904, 566);
            this.DiskTab.TabIndex = 2;
            this.DiskTab.Text = "Storage";
            this.DiskTab.UseVisualStyleBackColor = true;
            // 
            // metroLabel51
            // 
            this.metroLabel51.AutoSize = true;
            this.metroLabel51.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel51.Location = new System.Drawing.Point(864, 3);
            this.metroLabel51.Name = "metroLabel51";
            this.metroLabel51.Size = new System.Drawing.Size(37, 15);
            this.metroLabel51.TabIndex = 33;
            this.metroLabel51.Text = "Detail";
            this.metroLabel51.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDetailStorage
            // 
            this.btnDetailStorage.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnDetailStorage.ArrowDirection = System.Windows.Forms.ArrowDirection.Right;
            this.btnDetailStorage.ArrowHoverColor = System.Drawing.Color.Green;
            this.btnDetailStorage.ArrowPressedColor = System.Drawing.Color.Green;
            this.btnDetailStorage.BackColor = System.Drawing.Color.White;
            this.btnDetailStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDetailStorage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnDetailStorage.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(26)))));
            this.btnDetailStorage.BorderPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(26)))));
            this.btnDetailStorage.DefaultColor = System.Drawing.Color.White;
            this.btnDetailStorage.DisabledArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDetailStorage.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDetailStorage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetailStorage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDetailStorage.Location = new System.Drawing.Point(864, 21);
            this.btnDetailStorage.Name = "btnDetailStorage";
            this.btnDetailStorage.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(138)))), ((int)(((byte)(222)))), ((int)(((byte)(76)))));
            this.btnDetailStorage.Size = new System.Drawing.Size(37, 40);
            this.btnDetailStorage.TabIndex = 32;
            this.btnDetailStorage.Click += new System.EventHandler(this.Disk_More_Info_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.Disk_H_Status);
            this.groupBox11.Controls.Add(this.Disk_G_Status);
            this.groupBox11.Controls.Add(this.Disk_F_Status);
            this.groupBox11.Controls.Add(this.Disk_E_Status);
            this.groupBox11.Controls.Add(this.Disk_D_Status);
            this.groupBox11.Controls.Add(this.Disk_D_Caption);
            this.groupBox11.Controls.Add(this.gcpCUsage);
            this.groupBox11.Controls.Add(this.gcpDUsage);
            this.groupBox11.Controls.Add(this.gcpEUsage);
            this.groupBox11.Controls.Add(this.gcpFUsage);
            this.groupBox11.Controls.Add(this.gcpGUsage);
            this.groupBox11.Controls.Add(this.Disk_C_Caption);
            this.groupBox11.Controls.Add(this.Disk_C_Status);
            this.groupBox11.Controls.Add(this.Disk_H_Caption);
            this.groupBox11.Controls.Add(this.Disk_G_Caption);
            this.groupBox11.Controls.Add(this.Disk_E_Caption);
            this.groupBox11.Controls.Add(this.Disk_F_Caption);
            this.groupBox11.Controls.Add(this.gcpHUsage);
            this.groupBox11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox11.Location = new System.Drawing.Point(3, 96);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(898, 467);
            this.groupBox11.TabIndex = 29;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Information of volumes";
            // 
            // Disk_H_Status
            // 
            this.Disk_H_Status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_H_Status.Location = new System.Drawing.Point(672, 292);
            this.Disk_H_Status.Name = "Disk_H_Status";
            this.Disk_H_Status.Size = new System.Drawing.Size(200, 21);
            this.Disk_H_Status.TabIndex = 31;
            this.Disk_H_Status.Text = "H Used / H Total";
            this.Disk_H_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_G_Status
            // 
            this.Disk_G_Status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_G_Status.Location = new System.Drawing.Point(348, 292);
            this.Disk_G_Status.Name = "Disk_G_Status";
            this.Disk_G_Status.Size = new System.Drawing.Size(200, 21);
            this.Disk_G_Status.TabIndex = 30;
            this.Disk_G_Status.Text = "G Used / G Total";
            this.Disk_G_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_F_Status
            // 
            this.Disk_F_Status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_F_Status.Location = new System.Drawing.Point(21, 292);
            this.Disk_F_Status.Name = "Disk_F_Status";
            this.Disk_F_Status.Size = new System.Drawing.Size(200, 21);
            this.Disk_F_Status.TabIndex = 29;
            this.Disk_F_Status.Text = "F Used / F Total";
            this.Disk_F_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_E_Status
            // 
            this.Disk_E_Status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_E_Status.Location = new System.Drawing.Point(672, 64);
            this.Disk_E_Status.Name = "Disk_E_Status";
            this.Disk_E_Status.Size = new System.Drawing.Size(200, 21);
            this.Disk_E_Status.TabIndex = 28;
            this.Disk_E_Status.Text = "E Used / E Total";
            this.Disk_E_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_D_Status
            // 
            this.Disk_D_Status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_D_Status.Location = new System.Drawing.Point(348, 64);
            this.Disk_D_Status.Name = "Disk_D_Status";
            this.Disk_D_Status.Size = new System.Drawing.Size(200, 21);
            this.Disk_D_Status.TabIndex = 27;
            this.Disk_D_Status.Text = "D Used / D Total";
            this.Disk_D_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_D_Caption
            // 
            this.Disk_D_Caption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_D_Caption.Location = new System.Drawing.Point(385, 25);
            this.Disk_D_Caption.Name = "Disk_D_Caption";
            this.Disk_D_Caption.Size = new System.Drawing.Size(128, 21);
            this.Disk_D_Caption.TabIndex = 11;
            this.Disk_D_Caption.Text = "D:\\";
            this.Disk_D_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcpCUsage
            // 
            this.gcpCUsage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcpCUsage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gcpCUsage.ForeColor = System.Drawing.Color.Gray;
            this.gcpCUsage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(138)))), ((int)(((byte)(222)))), ((int)(((byte)(76)))));
            this.gcpCUsage.Location = new System.Drawing.Point(60, 94);
            this.gcpCUsage.Name = "gcpCUsage";
            this.gcpCUsage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcpCUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(26)))));
            this.gcpCUsage.Size = new System.Drawing.Size(128, 128);
            this.gcpCUsage.TabIndex = 1;
            this.gcpCUsage.Value = 0;
            // 
            // gcpDUsage
            // 
            this.gcpDUsage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcpDUsage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gcpDUsage.ForeColor = System.Drawing.Color.Gray;
            this.gcpDUsage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(138)))), ((int)(((byte)(222)))), ((int)(((byte)(76)))));
            this.gcpDUsage.Location = new System.Drawing.Point(385, 94);
            this.gcpDUsage.Name = "gcpDUsage";
            this.gcpDUsage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcpDUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(26)))));
            this.gcpDUsage.Size = new System.Drawing.Size(128, 128);
            this.gcpDUsage.TabIndex = 2;
            this.gcpDUsage.Value = 0;
            // 
            // gcpEUsage
            // 
            this.gcpEUsage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcpEUsage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gcpEUsage.ForeColor = System.Drawing.Color.Gray;
            this.gcpEUsage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(138)))), ((int)(((byte)(222)))), ((int)(((byte)(76)))));
            this.gcpEUsage.Location = new System.Drawing.Point(710, 94);
            this.gcpEUsage.Name = "gcpEUsage";
            this.gcpEUsage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcpEUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(26)))));
            this.gcpEUsage.Size = new System.Drawing.Size(128, 128);
            this.gcpEUsage.TabIndex = 3;
            this.gcpEUsage.Value = 0;
            // 
            // gcpFUsage
            // 
            this.gcpFUsage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcpFUsage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gcpFUsage.ForeColor = System.Drawing.Color.Gray;
            this.gcpFUsage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(138)))), ((int)(((byte)(222)))), ((int)(((byte)(76)))));
            this.gcpFUsage.Location = new System.Drawing.Point(60, 322);
            this.gcpFUsage.Name = "gcpFUsage";
            this.gcpFUsage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcpFUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(26)))));
            this.gcpFUsage.Size = new System.Drawing.Size(128, 128);
            this.gcpFUsage.TabIndex = 4;
            this.gcpFUsage.Value = 0;
            // 
            // gcpGUsage
            // 
            this.gcpGUsage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcpGUsage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gcpGUsage.ForeColor = System.Drawing.Color.Gray;
            this.gcpGUsage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(138)))), ((int)(((byte)(222)))), ((int)(((byte)(76)))));
            this.gcpGUsage.Location = new System.Drawing.Point(385, 322);
            this.gcpGUsage.Name = "gcpGUsage";
            this.gcpGUsage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcpGUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(26)))));
            this.gcpGUsage.Size = new System.Drawing.Size(128, 128);
            this.gcpGUsage.TabIndex = 5;
            this.gcpGUsage.Value = 0;
            // 
            // Disk_C_Caption
            // 
            this.Disk_C_Caption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_C_Caption.Location = new System.Drawing.Point(56, 25);
            this.Disk_C_Caption.Name = "Disk_C_Caption";
            this.Disk_C_Caption.Size = new System.Drawing.Size(132, 21);
            this.Disk_C_Caption.TabIndex = 9;
            this.Disk_C_Caption.Text = "C:\\";
            this.Disk_C_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_C_Status
            // 
            this.Disk_C_Status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_C_Status.Location = new System.Drawing.Point(21, 64);
            this.Disk_C_Status.Name = "Disk_C_Status";
            this.Disk_C_Status.Size = new System.Drawing.Size(200, 21);
            this.Disk_C_Status.TabIndex = 10;
            this.Disk_C_Status.Text = "C Used / C Total";
            this.Disk_C_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_H_Caption
            // 
            this.Disk_H_Caption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_H_Caption.Location = new System.Drawing.Point(706, 253);
            this.Disk_H_Caption.Name = "Disk_H_Caption";
            this.Disk_H_Caption.Size = new System.Drawing.Size(132, 21);
            this.Disk_H_Caption.TabIndex = 20;
            this.Disk_H_Caption.Text = "H:\\";
            this.Disk_H_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_G_Caption
            // 
            this.Disk_G_Caption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_G_Caption.Location = new System.Drawing.Point(385, 253);
            this.Disk_G_Caption.Name = "Disk_G_Caption";
            this.Disk_G_Caption.Size = new System.Drawing.Size(128, 21);
            this.Disk_G_Caption.TabIndex = 13;
            this.Disk_G_Caption.Text = "G:\\";
            this.Disk_G_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_E_Caption
            // 
            this.Disk_E_Caption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_E_Caption.Location = new System.Drawing.Point(706, 25);
            this.Disk_E_Caption.Name = "Disk_E_Caption";
            this.Disk_E_Caption.Size = new System.Drawing.Size(132, 21);
            this.Disk_E_Caption.TabIndex = 18;
            this.Disk_E_Caption.Text = "E:\\";
            this.Disk_E_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disk_F_Caption
            // 
            this.Disk_F_Caption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disk_F_Caption.Location = new System.Drawing.Point(56, 253);
            this.Disk_F_Caption.Name = "Disk_F_Caption";
            this.Disk_F_Caption.Size = new System.Drawing.Size(128, 21);
            this.Disk_F_Caption.TabIndex = 15;
            this.Disk_F_Caption.Text = "F:\\";
            this.Disk_F_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcpHUsage
            // 
            this.gcpHUsage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcpHUsage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gcpHUsage.ForeColor = System.Drawing.Color.Gray;
            this.gcpHUsage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(138)))), ((int)(((byte)(222)))), ((int)(((byte)(76)))));
            this.gcpHUsage.Location = new System.Drawing.Point(710, 322);
            this.gcpHUsage.Name = "gcpHUsage";
            this.gcpHUsage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcpHUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(26)))));
            this.gcpHUsage.Size = new System.Drawing.Size(128, 128);
            this.gcpHUsage.TabIndex = 17;
            this.gcpHUsage.Value = 0;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.metroLabel23.Location = new System.Drawing.Point(3, 3);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(162, 28);
            this.metroLabel23.TabIndex = 28;
            this.metroLabel23.Text = "Usage of Storage";
            // 
            // btnStorageRefresh
            // 
            this.btnStorageRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStorageRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnStorageRefresh.DefaultColor = System.Drawing.Color.White;
            this.btnStorageRefresh.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnStorageRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStorageRefresh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnStorageRefresh.Location = new System.Drawing.Point(388, 27);
            this.btnStorageRefresh.Name = "btnStorageRefresh";
            this.btnStorageRefresh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStorageRefresh.Size = new System.Drawing.Size(128, 40);
            this.btnStorageRefresh.TabIndex = 0;
            this.btnStorageRefresh.Text = "Refresh";
            this.btnStorageRefresh.Click += new System.EventHandler(this.Disk_Refresh_Click);
            // 
            // MemoryTab
            // 
            this.MemoryTab.Controls.Add(this.lblMemorySummary);
            this.MemoryTab.Controls.Add(this.groupBox10);
            this.MemoryTab.Controls.Add(this.groupBox9);
            this.MemoryTab.Controls.Add(this.cboMemoryRefreshSpeed);
            this.MemoryTab.Controls.Add(this.metroLabel14);
            this.MemoryTab.Controls.Add(this.metroLabel21);
            this.MemoryTab.Controls.Add(this.swMemoryRefresh);
            this.MemoryTab.Controls.Add(this.trkMemory);
            this.MemoryTab.Location = new System.Drawing.Point(124, 4);
            this.MemoryTab.Name = "MemoryTab";
            this.MemoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.MemoryTab.Size = new System.Drawing.Size(904, 566);
            this.MemoryTab.TabIndex = 1;
            this.MemoryTab.Text = "Memory";
            this.MemoryTab.UseVisualStyleBackColor = true;
            // 
            // lblMemorySummary
            // 
            this.lblMemorySummary.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblMemorySummary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMemorySummary.Location = new System.Drawing.Point(249, 3);
            this.lblMemorySummary.Name = "lblMemorySummary";
            this.lblMemorySummary.Size = new System.Drawing.Size(649, 49);
            this.lblMemorySummary.TabIndex = 47;
            this.lblMemorySummary.Text = "Memroy summary";
            this.lblMemorySummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.metroLabel48);
            this.groupBox10.Controls.Add(this.metroLabel27);
            this.groupBox10.Controls.Add(this.metroLabel28);
            this.groupBox10.Controls.Add(this.metroLabel29);
            this.groupBox10.Controls.Add(this.metroLabel30);
            this.groupBox10.Controls.Add(this.lblMemoryManufacturer);
            this.groupBox10.Controls.Add(this.lblMemorySpeed);
            this.groupBox10.Controls.Add(this.lblMemoryVoltage);
            this.groupBox10.Controls.Add(this.lblVirtualMemorySize);
            this.groupBox10.Controls.Add(this.lblMemoryPhysicalSize);
            this.groupBox10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox10.Location = new System.Drawing.Point(374, 346);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(524, 214);
            this.groupBox10.TabIndex = 46;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Information of memory";
            // 
            // metroLabel48
            // 
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel48.Location = new System.Drawing.Point(6, 25);
            this.metroLabel48.Name = "metroLabel48";
            this.metroLabel48.Size = new System.Drawing.Size(111, 21);
            this.metroLabel48.TabIndex = 49;
            this.metroLabel48.Text = "Manufacturer :";
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel27.Location = new System.Drawing.Point(6, 140);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(202, 21);
            this.metroLabel27.TabIndex = 45;
            this.metroLabel27.Text = "Total physical memory size :";
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel28.Location = new System.Drawing.Point(6, 181);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(190, 21);
            this.metroLabel28.TabIndex = 46;
            this.metroLabel28.Text = "Total virtual memory size :";
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel29.Location = new System.Drawing.Point(6, 61);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(91, 21);
            this.metroLabel29.TabIndex = 47;
            this.metroLabel29.Text = "Frequently :";
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel30.Location = new System.Drawing.Point(6, 101);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(125, 21);
            this.metroLabel30.TabIndex = 48;
            this.metroLabel30.Text = "Current voltage :";
            // 
            // lblMemoryManufacturer
            // 
            this.lblMemoryManufacturer.AutoSize = true;
            this.lblMemoryManufacturer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMemoryManufacturer.Location = new System.Drawing.Point(123, 25);
            this.lblMemoryManufacturer.Name = "lblMemoryManufacturer";
            this.lblMemoryManufacturer.Size = new System.Drawing.Size(68, 21);
            this.lblMemoryManufacturer.TabIndex = 44;
            this.lblMemoryManufacturer.Text = "Unknow";
            // 
            // lblMemorySpeed
            // 
            this.lblMemorySpeed.AutoSize = true;
            this.lblMemorySpeed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMemorySpeed.Location = new System.Drawing.Point(103, 61);
            this.lblMemorySpeed.Name = "lblMemorySpeed";
            this.lblMemorySpeed.Size = new System.Drawing.Size(68, 21);
            this.lblMemorySpeed.TabIndex = 41;
            this.lblMemorySpeed.Text = "Unknow";
            // 
            // lblMemoryVoltage
            // 
            this.lblMemoryVoltage.AutoSize = true;
            this.lblMemoryVoltage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMemoryVoltage.Location = new System.Drawing.Point(137, 101);
            this.lblMemoryVoltage.Name = "lblMemoryVoltage";
            this.lblMemoryVoltage.Size = new System.Drawing.Size(68, 21);
            this.lblMemoryVoltage.TabIndex = 42;
            this.lblMemoryVoltage.Text = "Unknow";
            // 
            // lblVirtualMemorySize
            // 
            this.lblVirtualMemorySize.AutoSize = true;
            this.lblVirtualMemorySize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblVirtualMemorySize.Location = new System.Drawing.Point(202, 181);
            this.lblVirtualMemorySize.Name = "lblVirtualMemorySize";
            this.lblVirtualMemorySize.Size = new System.Drawing.Size(68, 21);
            this.lblVirtualMemorySize.TabIndex = 40;
            this.lblVirtualMemorySize.Text = "Unknow";
            // 
            // lblMemoryPhysicalSize
            // 
            this.lblMemoryPhysicalSize.AutoSize = true;
            this.lblMemoryPhysicalSize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMemoryPhysicalSize.Location = new System.Drawing.Point(214, 140);
            this.lblMemoryPhysicalSize.Name = "lblMemoryPhysicalSize";
            this.lblMemoryPhysicalSize.Size = new System.Drawing.Size(68, 21);
            this.lblMemoryPhysicalSize.TabIndex = 39;
            this.lblMemoryPhysicalSize.Text = "Unknow";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.metroLabel15);
            this.groupBox9.Controls.Add(this.metroLabel26);
            this.groupBox9.Controls.Add(this.lblVirtualMemoryUsed);
            this.groupBox9.Controls.Add(this.gcpPhysicalMemoryUsage);
            this.groupBox9.Controls.Add(this.lblPhysicalMemoryUsed);
            this.groupBox9.Controls.Add(this.gcpVirtualMemoryUsage);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox9.Location = new System.Drawing.Point(6, 346);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(362, 214);
            this.groupBox9.TabIndex = 45;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Real-time information";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel15.Location = new System.Drawing.Point(8, 48);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(174, 21);
            this.metroLabel15.TabIndex = 45;
            this.metroLabel15.Text = "Physical memory usage";
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel26.Location = new System.Drawing.Point(192, 48);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(164, 21);
            this.metroLabel26.TabIndex = 46;
            this.metroLabel26.Text = "Virtual memory usage";
            // 
            // lblVirtualMemoryUsed
            // 
            this.lblVirtualMemoryUsed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblVirtualMemoryUsed.Location = new System.Drawing.Point(190, 173);
            this.lblVirtualMemoryUsed.Name = "lblVirtualMemoryUsed";
            this.lblVirtualMemoryUsed.Size = new System.Drawing.Size(172, 21);
            this.lblVirtualMemoryUsed.TabIndex = 44;
            this.lblVirtualMemoryUsed.Text = "Unknow";
            this.lblVirtualMemoryUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcpPhysicalMemoryUsage
            // 
            this.gcpPhysicalMemoryUsage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcpPhysicalMemoryUsage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gcpPhysicalMemoryUsage.ForeColor = System.Drawing.Color.White;
            this.gcpPhysicalMemoryUsage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(241)))), ((int)(((byte)(68)))), ((int)(((byte)(224)))));
            this.gcpPhysicalMemoryUsage.Location = new System.Drawing.Point(44, 70);
            this.gcpPhysicalMemoryUsage.Name = "gcpPhysicalMemoryUsage";
            this.gcpPhysicalMemoryUsage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcpPhysicalMemoryUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(18)))), ((int)(((byte)(174)))));
            this.gcpPhysicalMemoryUsage.Size = new System.Drawing.Size(100, 100);
            this.gcpPhysicalMemoryUsage.TabIndex = 25;
            // 
            // lblPhysicalMemoryUsed
            // 
            this.lblPhysicalMemoryUsed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPhysicalMemoryUsed.Location = new System.Drawing.Point(10, 173);
            this.lblPhysicalMemoryUsed.Name = "lblPhysicalMemoryUsed";
            this.lblPhysicalMemoryUsed.Size = new System.Drawing.Size(172, 21);
            this.lblPhysicalMemoryUsed.TabIndex = 43;
            this.lblPhysicalMemoryUsed.Text = "Unknow";
            this.lblPhysicalMemoryUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcpVirtualMemoryUsage
            // 
            this.gcpVirtualMemoryUsage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcpVirtualMemoryUsage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gcpVirtualMemoryUsage.ForeColor = System.Drawing.Color.White;
            this.gcpVirtualMemoryUsage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(241)))), ((int)(((byte)(68)))), ((int)(((byte)(224)))));
            this.gcpVirtualMemoryUsage.Location = new System.Drawing.Point(223, 72);
            this.gcpVirtualMemoryUsage.Name = "gcpVirtualMemoryUsage";
            this.gcpVirtualMemoryUsage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcpVirtualMemoryUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(18)))), ((int)(((byte)(174)))));
            this.gcpVirtualMemoryUsage.Size = new System.Drawing.Size(100, 100);
            this.gcpVirtualMemoryUsage.TabIndex = 33;
            // 
            // cboMemoryRefreshSpeed
            // 
            this.cboMemoryRefreshSpeed.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cboMemoryRefreshSpeed.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.cboMemoryRefreshSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.cboMemoryRefreshSpeed.DefaultColor = System.Drawing.Color.White;
            this.cboMemoryRefreshSpeed.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cboMemoryRefreshSpeed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMemoryRefreshSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemoryRefreshSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMemoryRefreshSpeed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMemoryRefreshSpeed.FormattingEnabled = true;
            this.cboMemoryRefreshSpeed.Items.AddRange(new object[] {
            "Fast \t(0.4s)",
            "Normal \t(1.0s)",
            "Slow\t(4.0s)"});
            this.cboMemoryRefreshSpeed.Location = new System.Drawing.Point(6, 24);
            this.cboMemoryRefreshSpeed.Name = "cboMemoryRefreshSpeed";
            this.cboMemoryRefreshSpeed.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cboMemoryRefreshSpeed.Size = new System.Drawing.Size(130, 24);
            this.cboMemoryRefreshSpeed.TabIndex = 27;
            this.cboMemoryRefreshSpeed.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cboMemoryRefreshSpeed.Value = "Normal (1.0s)";
            this.cboMemoryRefreshSpeed.SelectedIndexChanged += new System.EventHandler(this.MemoryRefreshSpeed_SelectedIndexChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel14.Location = new System.Drawing.Point(31, 7);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(80, 15);
            this.metroLabel14.TabIndex = 26;
            this.metroLabel14.Text = "Refresh speed";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel21.Location = new System.Drawing.Point(142, 7);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(72, 15);
            this.metroLabel21.TabIndex = 23;
            this.metroLabel21.Text = "Auto refresh";
            // 
            // swMemoryRefresh
            // 
            this.swMemoryRefresh.BackColor = System.Drawing.Color.White;
            this.swMemoryRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swMemoryRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.swMemoryRefresh.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.swMemoryRefresh.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.swMemoryRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swMemoryRefresh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.swMemoryRefresh.Location = new System.Drawing.Point(142, 25);
            this.swMemoryRefresh.Name = "swMemoryRefresh";
            this.swMemoryRefresh.Size = new System.Drawing.Size(75, 23);
            this.swMemoryRefresh.SwitchColor = System.Drawing.Color.White;
            this.swMemoryRefresh.TabIndex = 22;
            this.swMemoryRefresh.Text = "metroSwitch1";
            this.swMemoryRefresh.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.MemoryRefresh_CheckedChanged);
            // 
            // trkMemory
            // 
            this.trkMemory.BackColor = System.Drawing.Color.White;
            this.trkMemory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.trkMemory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.trkMemory.Location = new System.Drawing.Point(6, 55);
            this.trkMemory.Name = "trkMemory";
            this.trkMemory.ShowedValueCount = 100;
            this.trkMemory.Size = new System.Drawing.Size(892, 285);
            this.trkMemory.TabIndex = 21;
            this.trkMemory.Text = "100%";
            // 
            // MotherBoardTab
            // 
            this.MotherBoardTab.BackColor = System.Drawing.Color.White;
            this.MotherBoardTab.Controls.Add(this.groupBox8);
            this.MotherBoardTab.Controls.Add(this.groupBox7);
            this.MotherBoardTab.Controls.Add(this.groupBox6);
            this.MotherBoardTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MotherBoardTab.Location = new System.Drawing.Point(124, 4);
            this.MotherBoardTab.Name = "MotherBoardTab";
            this.MotherBoardTab.Size = new System.Drawing.Size(904, 566);
            this.MotherBoardTab.TabIndex = 5;
            this.MotherBoardTab.Text = "Motherboard";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.metroLabel13);
            this.groupBox8.Controls.Add(this.metroLabel11);
            this.groupBox8.Controls.Add(this.lblMotherboardSystemManufacturer);
            this.groupBox8.Controls.Add(this.lblMotherboardSystemVersion);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox8.Location = new System.Drawing.Point(413, 406);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(488, 157);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Other information";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel13.Location = new System.Drawing.Point(6, 40);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(166, 21);
            this.metroLabel13.TabIndex = 20;
            this.metroLabel13.Text = "System manufacturer :";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel11.Location = new System.Drawing.Point(6, 80);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(123, 21);
            this.metroLabel11.TabIndex = 19;
            this.metroLabel11.Text = "System version :";
            // 
            // lblMotherboardSystemManufacturer
            // 
            this.lblMotherboardSystemManufacturer.AutoSize = true;
            this.lblMotherboardSystemManufacturer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMotherboardSystemManufacturer.Location = new System.Drawing.Point(178, 40);
            this.lblMotherboardSystemManufacturer.Name = "lblMotherboardSystemManufacturer";
            this.lblMotherboardSystemManufacturer.Size = new System.Drawing.Size(68, 21);
            this.lblMotherboardSystemManufacturer.TabIndex = 15;
            this.lblMotherboardSystemManufacturer.Text = "Unknow";
            // 
            // lblMotherboardSystemVersion
            // 
            this.lblMotherboardSystemVersion.AutoSize = true;
            this.lblMotherboardSystemVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMotherboardSystemVersion.Location = new System.Drawing.Point(135, 80);
            this.lblMotherboardSystemVersion.Name = "lblMotherboardSystemVersion";
            this.lblMotherboardSystemVersion.Size = new System.Drawing.Size(68, 21);
            this.lblMotherboardSystemVersion.TabIndex = 18;
            this.lblMotherboardSystemVersion.Text = "Unknow";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.metroLabel19);
            this.groupBox7.Controls.Add(this.metroLabel18);
            this.groupBox7.Controls.Add(this.metroLabel17);
            this.groupBox7.Controls.Add(this.lblBiosVendor);
            this.groupBox7.Controls.Add(this.lblBiosReleaseDate);
            this.groupBox7.Controls.Add(this.lblBiosVersion);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox7.Location = new System.Drawing.Point(3, 406);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(404, 157);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "BIOS information";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel19.Location = new System.Drawing.Point(6, 40);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(138, 21);
            this.metroLabel19.TabIndex = 23;
            this.metroLabel19.Text = "BIOS release date :";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel18.Location = new System.Drawing.Point(6, 80);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(106, 21);
            this.metroLabel18.TabIndex = 22;
            this.metroLabel18.Text = "BIOS version :";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel17.Location = new System.Drawing.Point(6, 120);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(104, 21);
            this.metroLabel17.TabIndex = 21;
            this.metroLabel17.Text = "BIOS vendor :";
            // 
            // lblBiosVendor
            // 
            this.lblBiosVendor.AutoSize = true;
            this.lblBiosVendor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBiosVendor.Location = new System.Drawing.Point(116, 120);
            this.lblBiosVendor.Name = "lblBiosVendor";
            this.lblBiosVendor.Size = new System.Drawing.Size(68, 21);
            this.lblBiosVendor.TabIndex = 16;
            this.lblBiosVendor.Text = "Unknow";
            // 
            // lblBiosReleaseDate
            // 
            this.lblBiosReleaseDate.AutoSize = true;
            this.lblBiosReleaseDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBiosReleaseDate.Location = new System.Drawing.Point(150, 40);
            this.lblBiosReleaseDate.Name = "lblBiosReleaseDate";
            this.lblBiosReleaseDate.Size = new System.Drawing.Size(68, 21);
            this.lblBiosReleaseDate.TabIndex = 20;
            this.lblBiosReleaseDate.Text = "Unknow";
            // 
            // lblBiosVersion
            // 
            this.lblBiosVersion.AutoSize = true;
            this.lblBiosVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBiosVersion.Location = new System.Drawing.Point(118, 80);
            this.lblBiosVersion.Name = "lblBiosVersion";
            this.lblBiosVersion.Size = new System.Drawing.Size(68, 21);
            this.lblBiosVersion.TabIndex = 17;
            this.lblBiosVersion.Text = "Unknow";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.metroLabel22);
            this.groupBox6.Controls.Add(this.metroLabel33);
            this.groupBox6.Controls.Add(this.metroLabel57);
            this.groupBox6.Controls.Add(this.metroLabel8);
            this.groupBox6.Controls.Add(this.lblMotherboardSystemProductName);
            this.groupBox6.Controls.Add(this.lblMotherboardManufacturer);
            this.groupBox6.Controls.Add(this.lblMotherboardProduct);
            this.groupBox6.Controls.Add(this.lblMotherboardVersion);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.Location = new System.Drawing.Point(3, 203);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(898, 197);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Information of Motherboard";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel22.Location = new System.Drawing.Point(6, 75);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(152, 21);
            this.metroLabel22.TabIndex = 23;
            this.metroLabel22.Text = "Base board product :";
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel33.Location = new System.Drawing.Point(6, 155);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(149, 21);
            this.metroLabel33.TabIndex = 25;
            this.metroLabel33.Text = "Base board version :";
            // 
            // metroLabel57
            // 
            this.metroLabel57.AutoSize = true;
            this.metroLabel57.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel57.Location = new System.Drawing.Point(6, 115);
            this.metroLabel57.Name = "metroLabel57";
            this.metroLabel57.Size = new System.Drawing.Size(169, 21);
            this.metroLabel57.TabIndex = 24;
            this.metroLabel57.Text = "System product name :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel8.Location = new System.Drawing.Point(6, 35);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(192, 21);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Base board manufacturer :";
            // 
            // lblMotherboardSystemProductName
            // 
            this.lblMotherboardSystemProductName.AutoSize = true;
            this.lblMotherboardSystemProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMotherboardSystemProductName.Location = new System.Drawing.Point(181, 115);
            this.lblMotherboardSystemProductName.Name = "lblMotherboardSystemProductName";
            this.lblMotherboardSystemProductName.Size = new System.Drawing.Size(68, 21);
            this.lblMotherboardSystemProductName.TabIndex = 21;
            this.lblMotherboardSystemProductName.Text = "Unknow";
            // 
            // lblMotherboardManufacturer
            // 
            this.lblMotherboardManufacturer.AutoSize = true;
            this.lblMotherboardManufacturer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMotherboardManufacturer.Location = new System.Drawing.Point(204, 35);
            this.lblMotherboardManufacturer.Name = "lblMotherboardManufacturer";
            this.lblMotherboardManufacturer.Size = new System.Drawing.Size(68, 21);
            this.lblMotherboardManufacturer.TabIndex = 13;
            this.lblMotherboardManufacturer.Text = "Unknow";
            // 
            // lblMotherboardProduct
            // 
            this.lblMotherboardProduct.AutoSize = true;
            this.lblMotherboardProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMotherboardProduct.Location = new System.Drawing.Point(164, 75);
            this.lblMotherboardProduct.Name = "lblMotherboardProduct";
            this.lblMotherboardProduct.Size = new System.Drawing.Size(68, 21);
            this.lblMotherboardProduct.TabIndex = 19;
            this.lblMotherboardProduct.Text = "Unknow";
            // 
            // lblMotherboardVersion
            // 
            this.lblMotherboardVersion.AutoSize = true;
            this.lblMotherboardVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMotherboardVersion.Location = new System.Drawing.Point(161, 155);
            this.lblMotherboardVersion.Name = "lblMotherboardVersion";
            this.lblMotherboardVersion.Size = new System.Drawing.Size(68, 21);
            this.lblMotherboardVersion.TabIndex = 14;
            this.lblMotherboardVersion.Text = "Unknow";
            // 
            // CPUTab
            // 
            this.CPUTab.Controls.Add(this.groupBox5);
            this.CPUTab.Controls.Add(this.groupBox4);
            this.CPUTab.Controls.Add(this.cboCpuRefreshSpeed);
            this.CPUTab.Controls.Add(this.metroLabel10);
            this.CPUTab.Controls.Add(this.lblCpuName);
            this.CPUTab.Controls.Add(this.metroLabel1);
            this.CPUTab.Controls.Add(this.swCpuRefresh);
            this.CPUTab.Controls.Add(this.trkCpu);
            this.CPUTab.Location = new System.Drawing.Point(124, 4);
            this.CPUTab.Name = "CPUTab";
            this.CPUTab.Padding = new System.Windows.Forms.Padding(3);
            this.CPUTab.Size = new System.Drawing.Size(904, 566);
            this.CPUTab.TabIndex = 0;
            this.CPUTab.Text = "CPU";
            this.CPUTab.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.metroLabel3);
            this.groupBox5.Controls.Add(this.gcpCpuUsage);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox5.Location = new System.Drawing.Point(6, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 214);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Real-time information";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel3.Location = new System.Drawing.Point(53, 40);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 21);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "CPU usage";
            // 
            // gcpCpuUsage
            // 
            this.gcpCpuUsage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcpCpuUsage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gcpCpuUsage.ForeColor = System.Drawing.Color.White;
            this.gcpCpuUsage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gcpCpuUsage.Location = new System.Drawing.Point(43, 64);
            this.gcpCpuUsage.Name = "gcpCpuUsage";
            this.gcpCpuUsage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcpCpuUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(116)))), ((int)(((byte)(178)))));
            this.gcpCpuUsage.Size = new System.Drawing.Size(100, 100);
            this.gcpCpuUsage.TabIndex = 18;
            this.gcpCpuUsage.Value = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel5);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Controls.Add(this.lblCpuVoltage);
            this.groupBox4.Controls.Add(this.lblCpuThread);
            this.groupBox4.Controls.Add(this.lblCpuL2Cache);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.metroLabel7);
            this.groupBox4.Controls.Add(this.lblCpuL3Cache);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Controls.Add(this.lblCpuClock);
            this.groupBox4.Controls.Add(this.metroLabel9);
            this.groupBox4.Controls.Add(this.lblCpuCore);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox4.Location = new System.Drawing.Point(214, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(684, 214);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information of CPU";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel5.Location = new System.Drawing.Point(331, 125);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 21);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "L2Cache :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel6.Location = new System.Drawing.Point(331, 165);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 21);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "L3Cache :";
            // 
            // lblCpuVoltage
            // 
            this.lblCpuVoltage.AutoSize = true;
            this.lblCpuVoltage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCpuVoltage.Location = new System.Drawing.Point(462, 85);
            this.lblCpuVoltage.Name = "lblCpuVoltage";
            this.lblCpuVoltage.Size = new System.Drawing.Size(68, 21);
            this.lblCpuVoltage.TabIndex = 9;
            this.lblCpuVoltage.Text = "Unknow";
            // 
            // lblCpuThread
            // 
            this.lblCpuThread.AutoSize = true;
            this.lblCpuThread.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCpuThread.Location = new System.Drawing.Point(189, 125);
            this.lblCpuThread.Name = "lblCpuThread";
            this.lblCpuThread.Size = new System.Drawing.Size(68, 21);
            this.lblCpuThread.TabIndex = 17;
            this.lblCpuThread.Text = "Unknow";
            // 
            // lblCpuL2Cache
            // 
            this.lblCpuL2Cache.AutoSize = true;
            this.lblCpuL2Cache.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCpuL2Cache.Location = new System.Drawing.Point(413, 125);
            this.lblCpuL2Cache.Name = "lblCpuL2Cache";
            this.lblCpuL2Cache.Size = new System.Drawing.Size(68, 21);
            this.lblCpuL2Cache.TabIndex = 12;
            this.lblCpuL2Cache.Text = "Unknow";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel4.Location = new System.Drawing.Point(331, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 21);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Current voltage :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel7.Location = new System.Drawing.Point(38, 85);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(57, 21);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Cores :";
            // 
            // lblCpuL3Cache
            // 
            this.lblCpuL3Cache.AutoSize = true;
            this.lblCpuL3Cache.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCpuL3Cache.Location = new System.Drawing.Point(413, 165);
            this.lblCpuL3Cache.Name = "lblCpuL3Cache";
            this.lblCpuL3Cache.Size = new System.Drawing.Size(68, 21);
            this.lblCpuL3Cache.TabIndex = 13;
            this.lblCpuL3Cache.Text = "Unknow";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel2.Location = new System.Drawing.Point(331, 45);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 21);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Clock :";
            // 
            // lblCpuClock
            // 
            this.lblCpuClock.AutoSize = true;
            this.lblCpuClock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCpuClock.Location = new System.Drawing.Point(392, 45);
            this.lblCpuClock.Name = "lblCpuClock";
            this.lblCpuClock.Size = new System.Drawing.Size(68, 21);
            this.lblCpuClock.TabIndex = 4;
            this.lblCpuClock.Text = "Unknow";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel9.Location = new System.Drawing.Point(38, 125);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(145, 21);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Logical processors :";
            // 
            // lblCpuCore
            // 
            this.lblCpuCore.AutoSize = true;
            this.lblCpuCore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCpuCore.Location = new System.Drawing.Point(101, 85);
            this.lblCpuCore.Name = "lblCpuCore";
            this.lblCpuCore.Size = new System.Drawing.Size(68, 21);
            this.lblCpuCore.TabIndex = 15;
            this.lblCpuCore.Text = "Unknow";
            // 
            // cboCpuRefreshSpeed
            // 
            this.cboCpuRefreshSpeed.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cboCpuRefreshSpeed.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.cboCpuRefreshSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.cboCpuRefreshSpeed.DefaultColor = System.Drawing.Color.White;
            this.cboCpuRefreshSpeed.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cboCpuRefreshSpeed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCpuRefreshSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCpuRefreshSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCpuRefreshSpeed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCpuRefreshSpeed.FormattingEnabled = true;
            this.cboCpuRefreshSpeed.Items.AddRange(new object[] {
            "Fast \t(0.4s)",
            "Normal \t(1.0s)",
            "Slow\t(4.0s)"});
            this.cboCpuRefreshSpeed.Location = new System.Drawing.Point(6, 26);
            this.cboCpuRefreshSpeed.Name = "cboCpuRefreshSpeed";
            this.cboCpuRefreshSpeed.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cboCpuRefreshSpeed.Size = new System.Drawing.Size(130, 24);
            this.cboCpuRefreshSpeed.TabIndex = 20;
            this.cboCpuRefreshSpeed.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cboCpuRefreshSpeed.Value = "Normal (1.0s)";
            this.cboCpuRefreshSpeed.SelectedIndexChanged += new System.EventHandler(this.CpuRefreshSpeed_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel10.Location = new System.Drawing.Point(31, 9);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(80, 15);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "Refresh speed";
            // 
            // lblCpuName
            // 
            this.lblCpuName.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblCpuName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCpuName.Location = new System.Drawing.Point(249, 5);
            this.lblCpuName.Name = "lblCpuName";
            this.lblCpuName.Size = new System.Drawing.Size(649, 49);
            this.lblCpuName.TabIndex = 3;
            this.lblCpuName.Text = "CPU Name";
            this.lblCpuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel1.Location = new System.Drawing.Point(142, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 15);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Auto refresh";
            // 
            // swCpuRefresh
            // 
            this.swCpuRefresh.BackColor = System.Drawing.Color.White;
            this.swCpuRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swCpuRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.swCpuRefresh.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.swCpuRefresh.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.swCpuRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swCpuRefresh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.swCpuRefresh.Location = new System.Drawing.Point(142, 27);
            this.swCpuRefresh.Name = "swCpuRefresh";
            this.swCpuRefresh.Size = new System.Drawing.Size(75, 23);
            this.swCpuRefresh.SwitchColor = System.Drawing.Color.White;
            this.swCpuRefresh.TabIndex = 1;
            this.swCpuRefresh.Text = "metroSwitch1";
            this.swCpuRefresh.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.CpuRefresh_CheckedChanged);
            // 
            // trkCpu
            // 
            this.trkCpu.BackColor = System.Drawing.Color.White;
            this.trkCpu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.trkCpu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.trkCpu.Location = new System.Drawing.Point(6, 56);
            this.trkCpu.Name = "trkCpu";
            this.trkCpu.ShowedValueCount = 100;
            this.trkCpu.Size = new System.Drawing.Size(892, 290);
            this.trkCpu.TabIndex = 0;
            this.trkCpu.Text = "100%";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.AnimationSpeed = 20;
            this.metroTabControl1.Appearance = System.Windows.Forms.Appearance.Normal;
            this.metroTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.metroTabControl1.Controls.Add(this.CPUTab);
            this.metroTabControl1.Controls.Add(this.MemoryTab);
            this.metroTabControl1.Controls.Add(this.DiskTab);
            this.metroTabControl1.Controls.Add(this.GPUTab);
            this.metroTabControl1.Controls.Add(this.MotherBoardTab);
            this.metroTabControl1.Controls.Add(this.OSTab);
            this.metroTabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroTabControl1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroTabControl1.HeaderItemColor = System.Drawing.Color.White;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroTabControl1.HoverColor = System.Drawing.Color.White;
            this.metroTabControl1.ItemColor = System.Drawing.Color.White;
            this.metroTabControl1.ItemForeColor = System.Drawing.Color.Black;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(45, 120);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroTabControl1.SelectedForeColor = System.Drawing.Color.White;
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroTabControl1.SelectedItemLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroTabControl1.Size = new System.Drawing.Size(1032, 574);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.TabContainerColor = System.Drawing.Color.White;
            this.metroTabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 660);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Loading...";
            this.OSTab.ResumeLayout(false);
            this.OSTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GPUTab.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.DiskTab.ResumeLayout(false);
            this.DiskTab.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.MemoryTab.ResumeLayout(false);
            this.MemoryTab.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.MotherBoardTab.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.CPUTab.ResumeLayout(false);
            this.CPUTab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrGraphUpdater;
        private System.Windows.Forms.TabPage OSTab;
        private System.Windows.Forms.TabPage GPUTab;
        private System.Windows.Forms.TabPage DiskTab;
        private MetroSuite.MetroLabel metroLabel23;
        private MetroSuite.MetroLabel Disk_H_Caption;
        private MetroSuite.MetroLabel Disk_E_Caption;
        private GChartLib.GCircularProgress gcpHUsage;
        private MetroSuite.MetroLabel Disk_F_Caption;
        private MetroSuite.MetroLabel Disk_G_Caption;
        private MetroSuite.MetroLabel Disk_D_Caption;
        private MetroSuite.MetroLabel Disk_C_Status;
        private MetroSuite.MetroLabel Disk_C_Caption;
        private GChartLib.GCircularProgress gcpGUsage;
        private GChartLib.GCircularProgress gcpFUsage;
        private GChartLib.GCircularProgress gcpEUsage;
        private GChartLib.GCircularProgress gcpDUsage;
        private GChartLib.GCircularProgress gcpCUsage;
        private MetroSuite.MetroButton btnStorageRefresh;
        private System.Windows.Forms.TabPage MemoryTab;
        private MetroSuite.MetroLabel lblVirtualMemoryUsed;
        private MetroSuite.MetroLabel lblPhysicalMemoryUsed;
        private MetroSuite.MetroLabel lblMemoryVoltage;
        private MetroSuite.MetroLabel lblMemorySpeed;
        private MetroSuite.MetroLabel lblVirtualMemorySize;
        private MetroSuite.MetroLabel lblMemoryPhysicalSize;
        private GChartLib.GCircularProgress gcpVirtualMemoryUsage;
        private MetroSuite.MetroComboBox cboMemoryRefreshSpeed;
        private MetroSuite.MetroLabel metroLabel14;
        private GChartLib.GCircularProgress gcpPhysicalMemoryUsage;
        private MetroSuite.MetroLabel metroLabel21;
        private MetroSuite.MetroSwitch swMemoryRefresh;
        private MetroSuite.MetroTracker trkMemory;
        private System.Windows.Forms.TabPage MotherBoardTab;
        private MetroSuite.MetroLabel lblMotherboardSystemProductName;
        private MetroSuite.MetroLabel lblBiosReleaseDate;
        private MetroSuite.MetroLabel lblMotherboardProduct;
        private MetroSuite.MetroLabel lblMotherboardSystemVersion;
        private MetroSuite.MetroLabel lblBiosVersion;
        private MetroSuite.MetroLabel lblBiosVendor;
        private MetroSuite.MetroLabel lblMotherboardSystemManufacturer;
        private MetroSuite.MetroLabel lblMotherboardVersion;
        private MetroSuite.MetroLabel lblMotherboardManufacturer;
        private System.Windows.Forms.TabPage CPUTab;
        private MetroSuite.MetroComboBox cboCpuRefreshSpeed;
        private MetroSuite.MetroLabel metroLabel10;
        private GChartLib.GCircularProgress gcpCpuUsage;
        private MetroSuite.MetroLabel lblCpuThread;
        private MetroSuite.MetroLabel metroLabel9;
        private MetroSuite.MetroLabel lblCpuCore;
        private MetroSuite.MetroLabel metroLabel7;
        private MetroSuite.MetroLabel lblCpuL3Cache;
        private MetroSuite.MetroLabel lblCpuL2Cache;
        private MetroSuite.MetroLabel metroLabel6;
        private MetroSuite.MetroLabel metroLabel5;
        private MetroSuite.MetroLabel lblCpuVoltage;
        private MetroSuite.MetroLabel metroLabel4;
        private MetroSuite.MetroLabel metroLabel3;
        private MetroSuite.MetroLabel metroLabel2;
        private MetroSuite.MetroLabel lblCpuClock;
        private MetroSuite.MetroLabel lblCpuName;
        private MetroSuite.MetroLabel metroLabel1;
        private MetroSuite.MetroSwitch swCpuRefresh;
        private MetroSuite.MetroTracker trkCpu;
        private MetroSuite.MetroTabControl metroTabControl1;
        private MetroSuite.MetroLabel lblMonitorCurrentResolution;
        private MetroSuite.MetroLabel lblMonitorCurrentRefreshRate;
        private MetroSuite.MetroLabel lblGpuCaption;
        private MetroSuite.MetroLabel lblGpuDriverDate;
        private MetroSuite.MetroLabel lblMonitorMaxRefreshRate;
        private MetroSuite.MetroLabel lblMonitorMinRefreshRate;
        private MetroSuite.MetroLabel lblGpuDriverVersion;
        private MetroSuite.MetroLabel lblGpuVideoProcessName;
        private MetroSuite.MetroLabel lblGpuManufacturer;
        private MetroSuite.MetroLabel lblGpuMemorySize;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroSuite.MetroLabel lblOsArchitecture;
        private MetroSuite.MetroLabel lblOsCaption;
        private MetroSuite.MetroLabel metroLabel32;
        private MetroSuite.MetroLabel lblOsSerialNumber;
        private MetroSuite.MetroLabel lblOsVersion;
        private MetroSuite.MetroLabel lblOsBuildNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroSuite.MetroLabel lblOsLanguage;
        private MetroSuite.MetroLabel lblOsMuiLanguagesCode;
        private MetroSuite.MetroLabel lblOsCurrentTimeZone;
        private MetroSuite.MetroLabel lblOsContryCode;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroSuite.MetroLabel lblOsLastBootUpTime;
        private MetroSuite.MetroLabel lblOsInstallTime;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox12;
        private MetroSuite.MetroLabel lblMemoryManufacturer;
        private MetroSuite.MetroLabel Disk_E_Status;
        private MetroSuite.MetroLabel Disk_D_Status;
        private MetroSuite.MetroLabel Disk_H_Status;
        private MetroSuite.MetroLabel Disk_G_Status;
        private MetroSuite.MetroLabel Disk_F_Status;
        private MetroSuite.MetroLabel metroLabel22;
        private MetroSuite.MetroLabel metroLabel33;
        private MetroSuite.MetroLabel metroLabel57;
        private MetroSuite.MetroLabel metroLabel8;
        private MetroSuite.MetroLabel metroLabel19;
        private MetroSuite.MetroLabel metroLabel18;
        private MetroSuite.MetroLabel metroLabel17;
        private MetroSuite.MetroLabel metroLabel13;
        private MetroSuite.MetroLabel metroLabel11;
        private MetroSuite.MetroLabel metroLabel15;
        private MetroSuite.MetroLabel metroLabel26;
        private MetroSuite.MetroLabel metroLabel46;
        private MetroSuite.MetroLabel metroLabel44;
        private MetroSuite.MetroLabel metroLabel25;
        private MetroSuite.MetroLabel metroLabel38;
        private MetroSuite.MetroLabel metroLabel43;
        private MetroSuite.MetroLabel metroLabel45;
        private MetroSuite.MetroLabel metroLabel39;
        private MetroSuite.MetroLabel metroLabel42;
        private MetroSuite.MetroLabel metroLabel41;
        private MetroSuite.MetroLabel metroLabel40;
        private MetroSuite.MetroLabel metroLabel16;
        private MetroSuite.MetroLabel metroLabel20;
        private MetroSuite.MetroLabel metroLabel58;
        private MetroSuite.MetroLabel metroLabel59;
        private MetroSuite.MetroLabel metroLabel60;
        private MetroSuite.MetroLabel metroLabel24;
        private MetroSuite.MetroLabel metroLabel31;
        private MetroSuite.MetroLabel metroLabel34;
        private MetroSuite.MetroLabel metroLabel36;
        private MetroSuite.MetroLabel metroLabel47;
        private MetroSuite.MetroLabel metroLabel49;
        private MetroSuite.MetroLabel metroLabel48;
        private MetroSuite.MetroLabel metroLabel27;
        private MetroSuite.MetroLabel metroLabel28;
        private MetroSuite.MetroLabel metroLabel29;
        private MetroSuite.MetroLabel metroLabel30;
        private MetroSuite.MetroNavigationButton btnDetailStorage;
        private MetroSuite.MetroLabel metroLabel51;
        private MetroSuite.MetroLabel lblMemorySummary;
    }
}

