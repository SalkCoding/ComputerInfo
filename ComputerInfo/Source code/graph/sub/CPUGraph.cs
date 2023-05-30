using MetroSuite;
using GChartLib;
using System;
using System.Diagnostics;

namespace ComputerInfo.Graph
{
    class CPUGraph : IGraph
    {
        private readonly PerformanceCounter cpuCounter;

        private readonly MetroTracker trkCpu;
        private readonly GCircularProgress gcpCpuUsage;
        private readonly MetroTrackerPath trackPath;

        public CPUGraph(MetroTracker trkCpu, GCircularProgress gcpCpuUsage)
        {
            this.trkCpu = trkCpu;
            this.gcpCpuUsage = gcpCpuUsage;

            cpuCounter = new PerformanceCounter
            {
                CategoryName = "Processor",
                CounterName = "% Processor Time",
                InstanceName = "_Total"
            };

            trackPath = new MetroTrackerPath
            {
                Name = "CPU",
                Style = MetroTrackerPath.PathStyle.CPU
            };
            trkCpu.Paths.Add(trackPath);
        }

        public void update()
        {
            double percent = cpuCounter.NextValue();
            int usage = Convert.ToInt32(percent);
            trackPath.Add(usage);
            gcpCpuUsage.Value = usage;
        }
    }
}
