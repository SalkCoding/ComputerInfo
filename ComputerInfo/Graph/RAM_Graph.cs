using GChartLib;
using MetroSuite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.Graph
{
    class RAM_Graph
    {

        MetroTrackerPath path = new MetroTrackerPath();

        public MetroTrackerPath GraphPath => path;

        public RAM_Graph()
        {
            path.Name = "RAM";
            path.Style = MetroTrackerPath.PathStyle.Memory;
        }

        public void RefreshGraph(MetroTracker trackbar, GCircularProgress Ram_Physical_Usage, GCircularProgress Ram_Virtual_Usage, MetroLabel Ram_Physical_Used_Size, MetroLabel Ram_Virtual_Used_Size)
        {
            UInt64 Physical_Available = WMI.Memory.RAM_Available_Physical;
            UInt64 Physical_Total = WMI.Memory.RAM_Pysical_Size;
            UInt64 Virtual_Available = WMI.Memory.RAM_Available_Virtual;
            UInt64 Virtual_Total = WMI.Memory.RAM_Virtual_Size;
            Double Physical_Percentage = (((Physical_Total - Physical_Available) * 100) / Physical_Total);
            Double Virtual_Percentage = (((Virtual_Total - Virtual_Available) * 100) / Virtual_Total);
            path.Add((Int32)Physical_Percentage);
            Ram_Physical_Usage.Value = (Int32)Physical_Percentage;
            Ram_Virtual_Usage.Value = (Int32)Virtual_Percentage;
            Ram_Physical_Used_Size.Text = String.Format("{0:F2} GB in use", ((WMI.Memory.RAM_Pysical_Size - WMI.Memory.RAM_Available_Physical) / 1024f / 1024f / 1024f));
            Ram_Virtual_Used_Size.Text = String.Format("{0:F2} GB in use", ((WMI.Memory.RAM_Virtual_Size - WMI.Memory.RAM_Available_Virtual) / 1024f / 1024f / 1024f));
        }
    }
}
