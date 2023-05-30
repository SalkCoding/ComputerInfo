using ComputerInfo.Define;
using ComputerInfo.Source_code.tabPage;
using ComputerInfo.WMI;
using MetroSuite;
using System;
using System.Collections.Generic;
using System.IO;

namespace ComputerInfo.TabPage
{
    internal class StorageTabPage : ITabPage
    {
        private readonly Storage storage;

        private readonly MetroLabel[] labelList;

        public StorageTabPage(
            Storage storage,
            MetroLabel[] labelList
            )
        {
            this.storage = storage;
            this.labelList = labelList;
        }

        private static readonly int DISK_MAX_COUNT = 6;
        public void update()
        {
            return;
            for (int i = DISK_MAX_COUNT; i > storage.VolumeCount; i--)
            {
                for (int j = (i * 2) - 1; j > (i * 2) - 2; j--)
                {
                    labelList[j].Text = "Not found";
                }
            }
            List<DriveInfo> driver = storage.VolumeList;
            int count = Math.Min(storage.VolumeCount, 6);
            for (int i = 0; i < count; i++)
            {
                labelList[i * 2].Text = driver[i].Name;
                if (driver[i].IsReady)
                    labelList[(i * 2) + 1].Text = string.Format("{0:F2} GB / {1:F2} GB", (driver[i].TotalFreeSpace / Constants.GIGABYTE_DIVIDE_CONSTANTS), (driver[i].TotalSize / Constants.GIGABYTE_DIVIDE_CONSTANTS));
                else
                    labelList[(i * 2) + 1].Text = "Volume is not ready";
            }
        }
    }
}
