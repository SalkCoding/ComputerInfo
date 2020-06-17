using ComputerInfo.WMI;
using GChartLib;
using MetroSuite;
using System;

namespace ComputerInfo.Graph
{
    class RAMGraph
    {

        public MetroTrackerPath GraphPath { get; } = new MetroTrackerPath();

        public RAMGraph()
        {
            GraphPath.Name = "RAM";
            GraphPath.Style = MetroTrackerPath.PathStyle.Memory;
        }

        public void RefreshGraph(RAM ram, GCircularProgress Ram_Physical_Usage, GCircularProgress Ram_Virtual_Usage, MetroLabel Ram_Physical_Used_Size, MetroLabel Ram_Virtual_Used_Size)
        {
            UInt64 physicalTotal = ram.PysicalSize;
            UInt64 physicalAvailable = ram.AvailablePhysicalSize;
            UInt64 virtualTotal = ram.VirtualSize;
            UInt64 virtualAvailable = ram.AvailableVirtualSize;
            Double physicalPercentage = (physicalTotal - physicalAvailable) * 100 / physicalTotal;
            Double virtualPercentage = (virtualTotal - virtualAvailable) * 100 / virtualTotal;
            GraphPath.Add((Int32)physicalPercentage);
            Ram_Physical_Usage.Value = (Int32)physicalPercentage;
            Ram_Virtual_Usage.Value = (Int32)virtualPercentage;
            Ram_Physical_Used_Size.Text = String.Format("{0:F2} GB in use", (physicalTotal - physicalAvailable) / 1024f / 1024f / 1024f);
            Ram_Virtual_Used_Size.Text = String.Format("{0:F2} GB in use", (virtualTotal - virtualAvailable) / 1024f / 1024f / 1024f);
        }
    }
}
