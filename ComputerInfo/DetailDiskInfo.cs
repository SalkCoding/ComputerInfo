using ComputerInfo.Define;
using ComputerInfo.WMI;
using System;

namespace ComputerInfo
{
    public partial class DetailDiskInfo : MetroFramework.Forms.MetroForm
    {
        public DetailDiskInfo()
        {
            InitializeComponent();
        }

        DetailStorage detailDisk;

        private void DiskMoreInfo_Load(object sender, EventArgs e)
        {
            detailDisk = new DetailStorage();
            var drives = detailDisk.DiskDrives;
            for (int i = 0; i < drives.Length; i++)
            {
                DetailDisk_DiskTree.Items.Add(drives[i]["Caption"]);
            }
            DetailDisk_DiskTree.SelectedIndex = 0;
        }

        private void DetailDisk_DiskTree_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drives = detailDisk.DiskDrives;
            int index = DetailDisk_DiskTree.SelectedIndex;
            MoreInfo_DeviceID.Text = drives[index][DetailStorage.Query.DeviceID].ToString();
            MoreInfo_Model.Text = drives[index][DetailStorage.Query.Model].ToString();
            MoreInfo_Size.Text = drives[index][DetailStorage.Query.Size].ToString() + string.Format(" Byte({0:0.00}GB)", Convert.ToDouble(drives[index][DetailStorage.Query.Size]) / 1024f / 1024f / 1024f);
            MoreInfo_Status.Text = drives[index][DetailStorage.Query.Status].ToString();
            MoreInfo_SystemName.Text = drives[index][DetailStorage.Query.SystemName].ToString();
            MoreInfo_Name.Text = drives[index][DetailStorage.Query.Name].ToString();
            MoreInfo_SerialNumber.Text = drives[index][DetailStorage.Query.SerialNumber].ToString();
            var signature = drives[index][DetailStorage.Query.Signature];
            MoreInfo_Signature.Text = signature != null ? signature.ToString() : "Unknown";
        }
    }
}
