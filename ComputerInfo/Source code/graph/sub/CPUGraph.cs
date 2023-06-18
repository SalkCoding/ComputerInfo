using MetroSuite;
using System;
using System.Diagnostics;

namespace ComputerInfo.Graph
{
    class CPUGraph : IGraph
    {
        private readonly PerformanceCounter cpuCounter;

        private readonly MetroTracker trkCpu;
        private readonly MetroTrackerPath trackPath;

        public CPUGraph(MetroTracker trkCpu)
        {
            this.trkCpu = trkCpu;

            cpuCounter = new PerformanceCounter
            {
                CategoryName = "Processor",
                CounterName = "% Processor Time",
                InstanceName = "_Total"
            };

            trackPath = new MetroTrackerPath
            {
                Name = "CPU Usage",
                Style = MetroTrackerPath.PathStyle.CPU,
                LineWidth = 2
            };
            trkCpu.Paths.Add(trackPath);
        }

        public void update()
        {
            double percent = cpuCounter.NextValue();
            int usage = Convert.ToInt32(percent);
            trackPath.Add(usage);
            trkCpu.Text = string.Format("{0:F1}%",percent);
        }
    }
}
