using System;
using ComputerInfo.Graph;
using ComputerInfo.Define;
using System.Management;
using MetroSuite;

namespace ComputerInfo
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        CPU_Graph Cpu_Graph = new CPU_Graph();
        RAM_Graph Ram_Graph = new RAM_Graph();
        public Form1()
        {
            //init
            InitializeComponent();
            WMI.CPU.Initialization();
            WMI.Bios.Initialization();
            WMI.Memory.Initialization();

            CPU_Tracker.Paths.Add(Cpu_Graph.GraphPath);
            RAM_Tracker.Paths.Add(Ram_Graph.GraphPath);
            Untill.PrintCPUInformation(CPUName, CPU_Clock, CPU_Voltage, CPU_L2CACHE, CPU_L3CACHE, CPU_CORE, CPU_THREAD);
            Untill.PrintBIOSInformation(BIOS_Base_Board_Manufacturer, BIOS_Base_Board_Product, BIOS_Base_Board_Version, BIOS_Release_Date, BIOS_Version, BIOS_Vendor, BIOS_System_Product_Name, BIOS_System_Manufacturer, BIOS_System_Version, BIOS_Logo);
            //Untill.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cpu_Graph.RefreshGraph(CPU_Tracker,CPU_Usage);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Ram_Graph.RefreshGraph(RAM_Tracker, RAM_Physical_Progress,RAM_Virtual_Progress);
        }

        private void Refresh_Speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Refresh_Speed.SelectedIndex)
            {
                case 0:
                    timer1.Interval = 300;
                    break;
                case 1:
                    timer1.Interval = 1000;
                    break;
                case 2:
                    timer1.Interval = 4000;
                    break;
            }
        }

        private void RefreshSwitch_CheckedChanged(object sender, bool isChecked)
        {
            if (!isChecked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        private void RAM_Refresh_Speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RAM_Refresh_Speed.SelectedIndex)
            {
                case 0:
                    timer2.Interval = 300;
                    break;
                case 1:
                    timer2.Interval = 1000;
                    break;
                case 2:
                    timer2.Interval = 4000;
                    break;
            }
        }

        private void RAM_Auto_Refresh_CheckedChanged(object sender, bool isChecked)
        {
            if (!isChecked)
                timer2.Enabled = true;
            else
                timer2.Enabled = false;
        }


    }
}
