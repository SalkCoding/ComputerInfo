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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OtherTab = new System.Windows.Forms.TabPage();
            this.GraphicCardTab = new System.Windows.Forms.TabPage();
            this.DiskTab = new System.Windows.Forms.TabPage();
            this.MemoryTab = new System.Windows.Forms.TabPage();
            this.metroLabel22 = new MetroSuite.MetroLabel();
            this.metroLabel23 = new MetroSuite.MetroLabel();
            this.metroLabel24 = new MetroSuite.MetroLabel();
            this.metroLabel25 = new MetroSuite.MetroLabel();
            this.RAM_Refresh_Speed = new MetroSuite.MetroComboBox();
            this.metroLabel14 = new MetroSuite.MetroLabel();
            this.RAM_Physical_Progress = new GChartLib.GCircularProgress();
            this.metroLabel15 = new MetroSuite.MetroLabel();
            this.metroLabel21 = new MetroSuite.MetroLabel();
            this.RAM_Auto_Refresh = new MetroSuite.MetroSwitch();
            this.RAM_Tracker = new MetroSuite.MetroTracker();
            this.CPUTab = new System.Windows.Forms.TabPage();
            this.Refresh_Speed = new MetroSuite.MetroComboBox();
            this.metroLabel10 = new MetroSuite.MetroLabel();
            this.CPU_Usage = new GChartLib.GCircularProgress();
            this.CPU_THREAD = new MetroSuite.MetroLabel();
            this.metroLabel9 = new MetroSuite.MetroLabel();
            this.CPU_CORE = new MetroSuite.MetroLabel();
            this.metroLabel7 = new MetroSuite.MetroLabel();
            this.CPU_L3CACHE = new MetroSuite.MetroLabel();
            this.CPU_L2CACHE = new MetroSuite.MetroLabel();
            this.metroLabel6 = new MetroSuite.MetroLabel();
            this.metroLabel5 = new MetroSuite.MetroLabel();
            this.CPU_Voltage = new MetroSuite.MetroLabel();
            this.metroLabel4 = new MetroSuite.MetroLabel();
            this.metroLabel3 = new MetroSuite.MetroLabel();
            this.metroLabel2 = new MetroSuite.MetroLabel();
            this.CPU_Clock = new MetroSuite.MetroLabel();
            this.CPUName = new MetroSuite.MetroLabel();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.RefreshSwitch = new MetroSuite.MetroSwitch();
            this.CPU_Tracker = new MetroSuite.MetroTracker();
            this.metroTabControl1 = new MetroSuite.MetroTabControl();
            this.BiosTab = new System.Windows.Forms.TabPage();
            this.BIOS_System_Product_Name = new MetroSuite.MetroLabel();
            this.BIOS_Release_Date = new MetroSuite.MetroLabel();
            this.BIOS_Base_Board_Product = new MetroSuite.MetroLabel();
            this.BIOS_System_Version = new MetroSuite.MetroLabel();
            this.BIOS_Version = new MetroSuite.MetroLabel();
            this.BIOS_Vendor = new MetroSuite.MetroLabel();
            this.BIOS_System_Manufacturer = new MetroSuite.MetroLabel();
            this.BIOS_Base_Board_Version = new MetroSuite.MetroLabel();
            this.BIOS_Base_Board_Manufacturer = new MetroSuite.MetroLabel();
            this.metroLabel20 = new MetroSuite.MetroLabel();
            this.metroLabel19 = new MetroSuite.MetroLabel();
            this.metroLabel18 = new MetroSuite.MetroLabel();
            this.metroLabel17 = new MetroSuite.MetroLabel();
            this.metroLabel16 = new MetroSuite.MetroLabel();
            this.metroLabel13 = new MetroSuite.MetroLabel();
            this.metroLabel12 = new MetroSuite.MetroLabel();
            this.metroLabel11 = new MetroSuite.MetroLabel();
            this.metroLabel8 = new MetroSuite.MetroLabel();
            this.BIOS_Logo = new System.Windows.Forms.WebBrowser();
            this.OS_Page = new System.Windows.Forms.TabPage();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.RAM_Virtual_Progress = new GChartLib.GCircularProgress();
            this.metroLabel26 = new MetroSuite.MetroLabel();
            this.MemoryTab.SuspendLayout();
            this.CPUTab.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.BiosTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OtherTab
            // 
            this.OtherTab.Location = new System.Drawing.Point(124, 4);
            this.OtherTab.Name = "OtherTab";
            this.OtherTab.Size = new System.Drawing.Size(776, 566);
            this.OtherTab.TabIndex = 4;
            this.OtherTab.Text = "Other";
            this.OtherTab.UseVisualStyleBackColor = true;
            // 
            // GraphicCardTab
            // 
            this.GraphicCardTab.Location = new System.Drawing.Point(124, 4);
            this.GraphicCardTab.Name = "GraphicCardTab";
            this.GraphicCardTab.Size = new System.Drawing.Size(776, 566);
            this.GraphicCardTab.TabIndex = 3;
            this.GraphicCardTab.Text = "Graphic Card";
            this.GraphicCardTab.UseVisualStyleBackColor = true;
            // 
            // DiskTab
            // 
            this.DiskTab.Location = new System.Drawing.Point(124, 4);
            this.DiskTab.Name = "DiskTab";
            this.DiskTab.Size = new System.Drawing.Size(776, 566);
            this.DiskTab.TabIndex = 2;
            this.DiskTab.Text = "Disk";
            this.DiskTab.UseVisualStyleBackColor = true;
            // 
            // MemoryTab
            // 
            this.MemoryTab.Controls.Add(this.RAM_Virtual_Progress);
            this.MemoryTab.Controls.Add(this.metroLabel26);
            this.MemoryTab.Controls.Add(this.metroLabel22);
            this.MemoryTab.Controls.Add(this.metroLabel23);
            this.MemoryTab.Controls.Add(this.metroLabel24);
            this.MemoryTab.Controls.Add(this.metroLabel25);
            this.MemoryTab.Controls.Add(this.RAM_Refresh_Speed);
            this.MemoryTab.Controls.Add(this.metroLabel14);
            this.MemoryTab.Controls.Add(this.RAM_Physical_Progress);
            this.MemoryTab.Controls.Add(this.metroLabel15);
            this.MemoryTab.Controls.Add(this.metroLabel21);
            this.MemoryTab.Controls.Add(this.RAM_Auto_Refresh);
            this.MemoryTab.Controls.Add(this.RAM_Tracker);
            this.MemoryTab.Location = new System.Drawing.Point(124, 4);
            this.MemoryTab.Name = "MemoryTab";
            this.MemoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.MemoryTab.Size = new System.Drawing.Size(776, 566);
            this.MemoryTab.TabIndex = 1;
            this.MemoryTab.Text = "Memory";
            this.MemoryTab.UseVisualStyleBackColor = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel22.Location = new System.Drawing.Point(138, 520);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(17, 21);
            this.metroLabel22.TabIndex = 31;
            this.metroLabel22.Text = "?";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel23.Location = new System.Drawing.Point(6, 520);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(126, 21);
            this.metroLabel23.TabIndex = 30;
            this.metroLabel23.Text = "Current Voltage :";
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel24.Location = new System.Drawing.Point(6, 480);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(59, 21);
            this.metroLabel24.TabIndex = 29;
            this.metroLabel24.Text = "Clock : ";
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel25.Location = new System.Drawing.Point(63, 480);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(17, 21);
            this.metroLabel25.TabIndex = 28;
            this.metroLabel25.Text = "?";
            // 
            // RAM_Refresh_Speed
            // 
            this.RAM_Refresh_Speed.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.RAM_Refresh_Speed.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.RAM_Refresh_Speed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.RAM_Refresh_Speed.DefaultColor = System.Drawing.Color.White;
            this.RAM_Refresh_Speed.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RAM_Refresh_Speed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RAM_Refresh_Speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RAM_Refresh_Speed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RAM_Refresh_Speed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RAM_Refresh_Speed.FormattingEnabled = true;
            this.RAM_Refresh_Speed.Items.AddRange(new object[] {
            "Fast (0.3s)",
            "Normal (1.0s)",
            "Slow (4.0s)"});
            this.RAM_Refresh_Speed.Location = new System.Drawing.Point(0, 20);
            this.RAM_Refresh_Speed.Name = "RAM_Refresh_Speed";
            this.RAM_Refresh_Speed.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.RAM_Refresh_Speed.Size = new System.Drawing.Size(130, 24);
            this.RAM_Refresh_Speed.TabIndex = 27;
            this.RAM_Refresh_Speed.TextAlignment = System.Drawing.StringAlignment.Center;
            this.RAM_Refresh_Speed.Value = "Normal (1.0s)";
            this.RAM_Refresh_Speed.SelectedIndexChanged += new System.EventHandler(this.RAM_Refresh_Speed_SelectedIndexChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel14.Location = new System.Drawing.Point(25, 3);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(81, 15);
            this.metroLabel14.TabIndex = 26;
            this.metroLabel14.Text = "Refresh Speed";
            // 
            // RAM_Physical_Progress
            // 
            this.RAM_Physical_Progress.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RAM_Physical_Progress.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.RAM_Physical_Progress.ForeColor = System.Drawing.Color.White;
            this.RAM_Physical_Progress.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RAM_Physical_Progress.Location = new System.Drawing.Point(10, 359);
            this.RAM_Physical_Progress.Name = "RAM_Physical_Progress";
            this.RAM_Physical_Progress.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RAM_Physical_Progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(18)))), ((int)(((byte)(174)))));
            this.RAM_Physical_Progress.Size = new System.Drawing.Size(100, 100);
            this.RAM_Physical_Progress.TabIndex = 25;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel15.Location = new System.Drawing.Point(6, 334);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(151, 21);
            this.metroLabel15.TabIndex = 24;
            this.metroLabel15.Text = "Physical RAM Usage";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel21.Location = new System.Drawing.Point(136, 3);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(75, 15);
            this.metroLabel21.TabIndex = 23;
            this.metroLabel21.Text = "Auto Refresh";
            // 
            // RAM_Auto_Refresh
            // 
            this.RAM_Auto_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RAM_Auto_Refresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.RAM_Auto_Refresh.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.RAM_Auto_Refresh.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.RAM_Auto_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RAM_Auto_Refresh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RAM_Auto_Refresh.Location = new System.Drawing.Point(136, 21);
            this.RAM_Auto_Refresh.Name = "RAM_Auto_Refresh";
            this.RAM_Auto_Refresh.Size = new System.Drawing.Size(75, 23);
            this.RAM_Auto_Refresh.SwitchColor = System.Drawing.Color.White;
            this.RAM_Auto_Refresh.TabIndex = 22;
            this.RAM_Auto_Refresh.Text = "metroSwitch1";
            this.RAM_Auto_Refresh.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.RAM_Auto_Refresh_CheckedChanged);
            // 
            // RAM_Tracker
            // 
            this.RAM_Tracker.BackColor = System.Drawing.Color.White;
            this.RAM_Tracker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.RAM_Tracker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RAM_Tracker.Location = new System.Drawing.Point(0, 44);
            this.RAM_Tracker.Name = "RAM_Tracker";
            this.RAM_Tracker.ShowedValueCount = 100;
            this.RAM_Tracker.Size = new System.Drawing.Size(776, 290);
            this.RAM_Tracker.TabIndex = 21;
            this.RAM_Tracker.Text = "100%";
            // 
            // CPUTab
            // 
            this.CPUTab.Controls.Add(this.Refresh_Speed);
            this.CPUTab.Controls.Add(this.metroLabel10);
            this.CPUTab.Controls.Add(this.CPU_Usage);
            this.CPUTab.Controls.Add(this.CPU_THREAD);
            this.CPUTab.Controls.Add(this.metroLabel9);
            this.CPUTab.Controls.Add(this.CPU_CORE);
            this.CPUTab.Controls.Add(this.metroLabel7);
            this.CPUTab.Controls.Add(this.CPU_L3CACHE);
            this.CPUTab.Controls.Add(this.CPU_L2CACHE);
            this.CPUTab.Controls.Add(this.metroLabel6);
            this.CPUTab.Controls.Add(this.metroLabel5);
            this.CPUTab.Controls.Add(this.CPU_Voltage);
            this.CPUTab.Controls.Add(this.metroLabel4);
            this.CPUTab.Controls.Add(this.metroLabel3);
            this.CPUTab.Controls.Add(this.metroLabel2);
            this.CPUTab.Controls.Add(this.CPU_Clock);
            this.CPUTab.Controls.Add(this.CPUName);
            this.CPUTab.Controls.Add(this.metroLabel1);
            this.CPUTab.Controls.Add(this.RefreshSwitch);
            this.CPUTab.Controls.Add(this.CPU_Tracker);
            this.CPUTab.Location = new System.Drawing.Point(124, 4);
            this.CPUTab.Name = "CPUTab";
            this.CPUTab.Padding = new System.Windows.Forms.Padding(3);
            this.CPUTab.Size = new System.Drawing.Size(776, 566);
            this.CPUTab.TabIndex = 0;
            this.CPUTab.Text = "CPU";
            this.CPUTab.UseVisualStyleBackColor = true;
            // 
            // Refresh_Speed
            // 
            this.Refresh_Speed.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Refresh_Speed.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Refresh_Speed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Refresh_Speed.DefaultColor = System.Drawing.Color.White;
            this.Refresh_Speed.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Refresh_Speed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Refresh_Speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Refresh_Speed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Speed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Refresh_Speed.FormattingEnabled = true;
            this.Refresh_Speed.Items.AddRange(new object[] {
            "Fast (0.3s)",
            "Normal (1.0s)",
            "Slow (4.0s)"});
            this.Refresh_Speed.Location = new System.Drawing.Point(0, 26);
            this.Refresh_Speed.Name = "Refresh_Speed";
            this.Refresh_Speed.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Refresh_Speed.Size = new System.Drawing.Size(130, 24);
            this.Refresh_Speed.TabIndex = 20;
            this.Refresh_Speed.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Refresh_Speed.Value = "Normal (1.0s)";
            this.Refresh_Speed.SelectedIndexChanged += new System.EventHandler(this.Refresh_Speed_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel10.Location = new System.Drawing.Point(25, 9);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(81, 15);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "Refresh Speed";
            // 
            // CPU_Usage
            // 
            this.CPU_Usage.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPU_Usage.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.CPU_Usage.ForeColor = System.Drawing.Color.White;
            this.CPU_Usage.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CPU_Usage.Location = new System.Drawing.Point(10, 365);
            this.CPU_Usage.Name = "CPU_Usage";
            this.CPU_Usage.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CPU_Usage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(116)))), ((int)(((byte)(178)))));
            this.CPU_Usage.Size = new System.Drawing.Size(100, 100);
            this.CPU_Usage.TabIndex = 18;
            // 
            // CPU_THREAD
            // 
            this.CPU_THREAD.AutoSize = true;
            this.CPU_THREAD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CPU_THREAD.Location = new System.Drawing.Point(608, 520);
            this.CPU_THREAD.Name = "CPU_THREAD";
            this.CPU_THREAD.Size = new System.Drawing.Size(17, 21);
            this.CPU_THREAD.TabIndex = 17;
            this.CPU_THREAD.Text = "?";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel9.Location = new System.Drawing.Point(450, 520);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(152, 21);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Number of Threads :";
            // 
            // CPU_CORE
            // 
            this.CPU_CORE.AutoSize = true;
            this.CPU_CORE.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CPU_CORE.Location = new System.Drawing.Point(593, 480);
            this.CPU_CORE.Name = "CPU_CORE";
            this.CPU_CORE.Size = new System.Drawing.Size(17, 21);
            this.CPU_CORE.TabIndex = 15;
            this.CPU_CORE.Text = "?";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel7.Location = new System.Drawing.Point(450, 480);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(137, 21);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Number of Cores :";
            // 
            // CPU_L3CACHE
            // 
            this.CPU_L3CACHE.AutoSize = true;
            this.CPU_L3CACHE.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CPU_L3CACHE.Location = new System.Drawing.Point(532, 440);
            this.CPU_L3CACHE.Name = "CPU_L3CACHE";
            this.CPU_L3CACHE.Size = new System.Drawing.Size(17, 21);
            this.CPU_L3CACHE.TabIndex = 13;
            this.CPU_L3CACHE.Text = "?";
            // 
            // CPU_L2CACHE
            // 
            this.CPU_L2CACHE.AutoSize = true;
            this.CPU_L2CACHE.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CPU_L2CACHE.Location = new System.Drawing.Point(532, 400);
            this.CPU_L2CACHE.Name = "CPU_L2CACHE";
            this.CPU_L2CACHE.Size = new System.Drawing.Size(17, 21);
            this.CPU_L2CACHE.TabIndex = 12;
            this.CPU_L2CACHE.Text = "?";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel6.Location = new System.Drawing.Point(450, 440);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 21);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "L3Cache :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel5.Location = new System.Drawing.Point(450, 400);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 21);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "L2Cache :";
            // 
            // CPU_Voltage
            // 
            this.CPU_Voltage.AutoSize = true;
            this.CPU_Voltage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CPU_Voltage.Location = new System.Drawing.Point(138, 520);
            this.CPU_Voltage.Name = "CPU_Voltage";
            this.CPU_Voltage.Size = new System.Drawing.Size(17, 21);
            this.CPU_Voltage.TabIndex = 9;
            this.CPU_Voltage.Text = "?";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel4.Location = new System.Drawing.Point(6, 520);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(126, 21);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Current Voltage :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel3.Location = new System.Drawing.Point(6, 340);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 21);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "CPU Usage";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel2.Location = new System.Drawing.Point(6, 480);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 21);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Clock : ";
            // 
            // CPU_Clock
            // 
            this.CPU_Clock.AutoSize = true;
            this.CPU_Clock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CPU_Clock.Location = new System.Drawing.Point(63, 480);
            this.CPU_Clock.Name = "CPU_Clock";
            this.CPU_Clock.Size = new System.Drawing.Size(17, 21);
            this.CPU_Clock.TabIndex = 4;
            this.CPU_Clock.Text = "?";
            // 
            // CPUName
            // 
            this.CPUName.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.CPUName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CPUName.Location = new System.Drawing.Point(217, 0);
            this.CPUName.Name = "CPUName";
            this.CPUName.Size = new System.Drawing.Size(555, 49);
            this.CPUName.TabIndex = 3;
            this.CPUName.Text = "CPUNAME";
            this.CPUName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel1.Location = new System.Drawing.Point(136, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 15);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Auto Refresh";
            // 
            // RefreshSwitch
            // 
            this.RefreshSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.RefreshSwitch.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.RefreshSwitch.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.RefreshSwitch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshSwitch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RefreshSwitch.Location = new System.Drawing.Point(136, 27);
            this.RefreshSwitch.Name = "RefreshSwitch";
            this.RefreshSwitch.Size = new System.Drawing.Size(75, 23);
            this.RefreshSwitch.SwitchColor = System.Drawing.Color.White;
            this.RefreshSwitch.TabIndex = 1;
            this.RefreshSwitch.Text = "metroSwitch1";
            this.RefreshSwitch.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.RefreshSwitch_CheckedChanged);
            // 
            // CPU_Tracker
            // 
            this.CPU_Tracker.BackColor = System.Drawing.Color.White;
            this.CPU_Tracker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.CPU_Tracker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CPU_Tracker.Location = new System.Drawing.Point(0, 50);
            this.CPU_Tracker.Name = "CPU_Tracker";
            this.CPU_Tracker.ShowedValueCount = 100;
            this.CPU_Tracker.Size = new System.Drawing.Size(776, 290);
            this.CPU_Tracker.TabIndex = 0;
            this.CPU_Tracker.Text = "100%";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.Appearance.Normal;
            this.metroTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.metroTabControl1.Controls.Add(this.CPUTab);
            this.metroTabControl1.Controls.Add(this.BiosTab);
            this.metroTabControl1.Controls.Add(this.MemoryTab);
            this.metroTabControl1.Controls.Add(this.DiskTab);
            this.metroTabControl1.Controls.Add(this.GraphicCardTab);
            this.metroTabControl1.Controls.Add(this.OS_Page);
            this.metroTabControl1.Controls.Add(this.OtherTab);
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
            this.metroTabControl1.Size = new System.Drawing.Size(904, 574);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.TabContainerColor = System.Drawing.Color.White;
            this.metroTabControl1.TabIndex = 1;
            // 
            // BiosTab
            // 
            this.BiosTab.BackColor = System.Drawing.Color.White;
            this.BiosTab.Controls.Add(this.BIOS_System_Product_Name);
            this.BiosTab.Controls.Add(this.BIOS_Release_Date);
            this.BiosTab.Controls.Add(this.BIOS_Base_Board_Product);
            this.BiosTab.Controls.Add(this.BIOS_System_Version);
            this.BiosTab.Controls.Add(this.BIOS_Version);
            this.BiosTab.Controls.Add(this.BIOS_Vendor);
            this.BiosTab.Controls.Add(this.BIOS_System_Manufacturer);
            this.BiosTab.Controls.Add(this.BIOS_Base_Board_Version);
            this.BiosTab.Controls.Add(this.BIOS_Base_Board_Manufacturer);
            this.BiosTab.Controls.Add(this.metroLabel20);
            this.BiosTab.Controls.Add(this.metroLabel19);
            this.BiosTab.Controls.Add(this.metroLabel18);
            this.BiosTab.Controls.Add(this.metroLabel17);
            this.BiosTab.Controls.Add(this.metroLabel16);
            this.BiosTab.Controls.Add(this.metroLabel13);
            this.BiosTab.Controls.Add(this.metroLabel12);
            this.BiosTab.Controls.Add(this.metroLabel11);
            this.BiosTab.Controls.Add(this.metroLabel8);
            this.BiosTab.Controls.Add(this.BIOS_Logo);
            this.BiosTab.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BiosTab.Location = new System.Drawing.Point(124, 4);
            this.BiosTab.Name = "BiosTab";
            this.BiosTab.Size = new System.Drawing.Size(776, 566);
            this.BiosTab.TabIndex = 5;
            this.BiosTab.Text = "Mother Board";
            // 
            // BIOS_System_Product_Name
            // 
            this.BIOS_System_Product_Name.AutoSize = true;
            this.BIOS_System_Product_Name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BIOS_System_Product_Name.Location = new System.Drawing.Point(658, 260);
            this.BIOS_System_Product_Name.Name = "BIOS_System_Product_Name";
            this.BIOS_System_Product_Name.Size = new System.Drawing.Size(17, 21);
            this.BIOS_System_Product_Name.TabIndex = 21;
            this.BIOS_System_Product_Name.Text = "?";
            // 
            // BIOS_Release_Date
            // 
            this.BIOS_Release_Date.AutoSize = true;
            this.BIOS_Release_Date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BIOS_Release_Date.Location = new System.Drawing.Point(156, 380);
            this.BIOS_Release_Date.Name = "BIOS_Release_Date";
            this.BIOS_Release_Date.Size = new System.Drawing.Size(17, 21);
            this.BIOS_Release_Date.TabIndex = 20;
            this.BIOS_Release_Date.Text = "?";
            // 
            // BIOS_Base_Board_Product
            // 
            this.BIOS_Base_Board_Product.AutoSize = true;
            this.BIOS_Base_Board_Product.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BIOS_Base_Board_Product.Location = new System.Drawing.Point(164, 300);
            this.BIOS_Base_Board_Product.Name = "BIOS_Base_Board_Product";
            this.BIOS_Base_Board_Product.Size = new System.Drawing.Size(17, 21);
            this.BIOS_Base_Board_Product.TabIndex = 19;
            this.BIOS_Base_Board_Product.Text = "?";
            // 
            // BIOS_System_Version
            // 
            this.BIOS_System_Version.AutoSize = true;
            this.BIOS_System_Version.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BIOS_System_Version.Location = new System.Drawing.Point(610, 340);
            this.BIOS_System_Version.Name = "BIOS_System_Version";
            this.BIOS_System_Version.Size = new System.Drawing.Size(17, 21);
            this.BIOS_System_Version.TabIndex = 18;
            this.BIOS_System_Version.Text = "?";
            // 
            // BIOS_Version
            // 
            this.BIOS_Version.AutoSize = true;
            this.BIOS_Version.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BIOS_Version.Location = new System.Drawing.Point(119, 420);
            this.BIOS_Version.Name = "BIOS_Version";
            this.BIOS_Version.Size = new System.Drawing.Size(17, 21);
            this.BIOS_Version.TabIndex = 17;
            this.BIOS_Version.Text = "?";
            // 
            // BIOS_Vendor
            // 
            this.BIOS_Vendor.AutoSize = true;
            this.BIOS_Vendor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BIOS_Vendor.Location = new System.Drawing.Point(117, 460);
            this.BIOS_Vendor.Name = "BIOS_Vendor";
            this.BIOS_Vendor.Size = new System.Drawing.Size(17, 21);
            this.BIOS_Vendor.TabIndex = 16;
            this.BIOS_Vendor.Text = "?";
            // 
            // BIOS_System_Manufacturer
            // 
            this.BIOS_System_Manufacturer.AutoSize = true;
            this.BIOS_System_Manufacturer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BIOS_System_Manufacturer.Location = new System.Drawing.Point(652, 300);
            this.BIOS_System_Manufacturer.Name = "BIOS_System_Manufacturer";
            this.BIOS_System_Manufacturer.Size = new System.Drawing.Size(17, 21);
            this.BIOS_System_Manufacturer.TabIndex = 15;
            this.BIOS_System_Manufacturer.Text = "?";
            // 
            // BIOS_Base_Board_Version
            // 
            this.BIOS_Base_Board_Version.AutoSize = true;
            this.BIOS_Base_Board_Version.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BIOS_Base_Board_Version.Location = new System.Drawing.Point(162, 340);
            this.BIOS_Base_Board_Version.Name = "BIOS_Base_Board_Version";
            this.BIOS_Base_Board_Version.Size = new System.Drawing.Size(17, 21);
            this.BIOS_Base_Board_Version.TabIndex = 14;
            this.BIOS_Base_Board_Version.Text = "?";
            // 
            // BIOS_Base_Board_Manufacturer
            // 
            this.BIOS_Base_Board_Manufacturer.AutoSize = true;
            this.BIOS_Base_Board_Manufacturer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BIOS_Base_Board_Manufacturer.Location = new System.Drawing.Point(204, 260);
            this.BIOS_Base_Board_Manufacturer.Name = "BIOS_Base_Board_Manufacturer";
            this.BIOS_Base_Board_Manufacturer.Size = new System.Drawing.Size(17, 21);
            this.BIOS_Base_Board_Manufacturer.TabIndex = 13;
            this.BIOS_Base_Board_Manufacturer.Text = "?";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel20.Location = new System.Drawing.Point(6, 340);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(150, 21);
            this.metroLabel20.TabIndex = 12;
            this.metroLabel20.Text = "Base Board Version :";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel19.Location = new System.Drawing.Point(6, 380);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(144, 21);
            this.metroLabel19.TabIndex = 11;
            this.metroLabel19.Text = "BIOS Release Date :";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel18.Location = new System.Drawing.Point(6, 420);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(107, 21);
            this.metroLabel18.TabIndex = 10;
            this.metroLabel18.Text = "BIOS Version :";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel17.Location = new System.Drawing.Point(6, 460);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(105, 21);
            this.metroLabel17.TabIndex = 9;
            this.metroLabel17.Text = "BIOS Vendor :";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel16.Location = new System.Drawing.Point(480, 260);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(172, 21);
            this.metroLabel16.TabIndex = 8;
            this.metroLabel16.Text = "System Product Name :";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel13.Location = new System.Drawing.Point(480, 300);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(166, 21);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "System Manufacturer :";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel12.Location = new System.Drawing.Point(6, 300);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(152, 21);
            this.metroLabel12.TabIndex = 4;
            this.metroLabel12.Text = "Base Board Product :";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel11.Location = new System.Drawing.Point(480, 340);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(124, 21);
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "System Version :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel8.Location = new System.Drawing.Point(6, 260);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(192, 21);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Base Board Manufacturer :";
            // 
            // BIOS_Logo
            // 
            this.BIOS_Logo.Location = new System.Drawing.Point(3, 3);
            this.BIOS_Logo.MinimumSize = new System.Drawing.Size(20, 20);
            this.BIOS_Logo.Name = "BIOS_Logo";
            this.BIOS_Logo.ScrollBarsEnabled = false;
            this.BIOS_Logo.Size = new System.Drawing.Size(770, 250);
            this.BIOS_Logo.TabIndex = 0;
            this.BIOS_Logo.Url = new System.Uri("http://post.phinf.naver.net/MjAxNzA3MDVfMTQ3/MDAxNDk5MjUxNTg2MjIw.V4DwmMEjlUi6n81" +
        "8eWwiH500XE22_3A-oBBRF6erLEwg.tKwunNjHea9jrTGUU3VBmvGF_CiWKuAC3jdKL5gtVSYg.JPEG/" +
        "rgwe893.jpg?type=w1200", System.UriKind.Absolute);
            // 
            // OS_Page
            // 
            this.OS_Page.Location = new System.Drawing.Point(124, 4);
            this.OS_Page.Name = "OS_Page";
            this.OS_Page.Padding = new System.Windows.Forms.Padding(3);
            this.OS_Page.Size = new System.Drawing.Size(776, 566);
            this.OS_Page.TabIndex = 6;
            this.OS_Page.Text = "Operation System";
            this.OS_Page.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // RAM_Virtual_Progress
            // 
            this.RAM_Virtual_Progress.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RAM_Virtual_Progress.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.RAM_Virtual_Progress.ForeColor = System.Drawing.Color.White;
            this.RAM_Virtual_Progress.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RAM_Virtual_Progress.Location = new System.Drawing.Point(170, 359);
            this.RAM_Virtual_Progress.Name = "RAM_Virtual_Progress";
            this.RAM_Virtual_Progress.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RAM_Virtual_Progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(18)))), ((int)(((byte)(174)))));
            this.RAM_Virtual_Progress.Size = new System.Drawing.Size(100, 100);
            this.RAM_Virtual_Progress.TabIndex = 33;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel26.Location = new System.Drawing.Point(166, 335);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(141, 21);
            this.metroLabel26.TabIndex = 32;
            this.metroLabel26.Text = "Virtual RAM Usage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 660);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "ComputerInfo";
            this.MemoryTab.ResumeLayout(false);
            this.MemoryTab.PerformLayout();
            this.CPUTab.ResumeLayout(false);
            this.CPUTab.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.BiosTab.ResumeLayout(false);
            this.BiosTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage OtherTab;
        private System.Windows.Forms.TabPage GraphicCardTab;
        private System.Windows.Forms.TabPage DiskTab;
        private System.Windows.Forms.TabPage MemoryTab;
        private System.Windows.Forms.TabPage CPUTab;
        private MetroSuite.MetroLabel CPU_Voltage;
        private MetroSuite.MetroLabel metroLabel4;
        private MetroSuite.MetroLabel metroLabel3;
        private MetroSuite.MetroLabel metroLabel2;
        private MetroSuite.MetroLabel CPU_Clock;
        private MetroSuite.MetroLabel CPUName;
        private MetroSuite.MetroLabel metroLabel1;
        private MetroSuite.MetroSwitch RefreshSwitch;
        private MetroSuite.MetroTracker CPU_Tracker;
        private MetroSuite.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage BiosTab;
        private MetroSuite.MetroLabel metroLabel5;
        private MetroSuite.MetroLabel metroLabel6;
        private MetroSuite.MetroLabel CPU_THREAD;
        private MetroSuite.MetroLabel metroLabel9;
        private MetroSuite.MetroLabel CPU_CORE;
        private MetroSuite.MetroLabel metroLabel7;
        private MetroSuite.MetroLabel CPU_L3CACHE;
        private MetroSuite.MetroLabel CPU_L2CACHE;
        private GChartLib.GCircularProgress CPU_Usage;
        private System.Windows.Forms.WebBrowser BIOS_Logo;
        private MetroSuite.MetroLabel metroLabel20;
        private MetroSuite.MetroLabel metroLabel19;
        private MetroSuite.MetroLabel metroLabel18;
        private MetroSuite.MetroLabel metroLabel17;
        private MetroSuite.MetroLabel metroLabel16;
        private MetroSuite.MetroLabel metroLabel13;
        private MetroSuite.MetroLabel metroLabel12;
        private MetroSuite.MetroLabel metroLabel11;
        private MetroSuite.MetroLabel metroLabel8;
        private MetroSuite.MetroLabel BIOS_System_Product_Name;
        private MetroSuite.MetroLabel BIOS_Release_Date;
        private MetroSuite.MetroLabel BIOS_Base_Board_Product;
        private MetroSuite.MetroLabel BIOS_System_Version;
        private MetroSuite.MetroLabel BIOS_Version;
        private MetroSuite.MetroLabel BIOS_Vendor;
        private MetroSuite.MetroLabel BIOS_System_Manufacturer;
        private MetroSuite.MetroLabel BIOS_Base_Board_Version;
        private MetroSuite.MetroLabel BIOS_Base_Board_Manufacturer;
        private MetroSuite.MetroComboBox Refresh_Speed;
        private MetroSuite.MetroLabel metroLabel10;
        private System.Windows.Forms.TabPage OS_Page;
        private MetroSuite.MetroComboBox RAM_Refresh_Speed;
        private MetroSuite.MetroLabel metroLabel14;
        private GChartLib.GCircularProgress RAM_Physical_Progress;
        private MetroSuite.MetroLabel metroLabel15;
        private MetroSuite.MetroLabel metroLabel21;
        private MetroSuite.MetroSwitch RAM_Auto_Refresh;
        private MetroSuite.MetroTracker RAM_Tracker;
        private MetroSuite.MetroLabel metroLabel22;
        private MetroSuite.MetroLabel metroLabel23;
        private MetroSuite.MetroLabel metroLabel24;
        private MetroSuite.MetroLabel metroLabel25;
        private System.Windows.Forms.Timer timer2;
        private GChartLib.GCircularProgress RAM_Virtual_Progress;
        private MetroSuite.MetroLabel metroLabel26;
    }
}

