using ComputerInfo.Properties;
using ComputerInfo.Source_code.tabPage;
using ComputerInfo.WMI;
using MetroSuite;
using System.Windows.Forms;

namespace ComputerInfo.TabPage
{
    internal class MotherBoardTabPage : ITabPage
    {
        private readonly Motherboard motherboard;

        private readonly MetroLabel lblMotherboardManufacturer;
        private readonly MetroLabel lblMotherboardProduct;
        private readonly MetroLabel lblMotherboardVersion;
        private readonly MetroLabel lblBiosReleaseDate;
        private readonly MetroLabel lblBiosVersion;
        private readonly MetroLabel lblBiosVendor;
        private readonly MetroLabel lblMotherboardSystemProductName;
        private readonly MetroLabel lblMotherboardSystemManufacturer;

        private readonly PictureBox picMotherboard;

        public MotherBoardTabPage(
            Motherboard motherboard,
            MetroLabel lblMotherboardManufacturer,
            MetroLabel lblMotherboardProduct,
            MetroLabel lblMotherboardVersion,
            MetroLabel lblBiosReleaseDate,
            MetroLabel lblBiosVersion,
            MetroLabel lblBiosVendor,
            MetroLabel lblMotherboardSystemProductName,
            MetroLabel lblMotherboardSystemManufacturer,
            PictureBox picMotherboard
            )
        {
            this.motherboard = motherboard;
            this.lblMotherboardManufacturer = lblMotherboardManufacturer;
            this.lblMotherboardProduct = lblMotherboardProduct;
            this.lblMotherboardVersion = lblMotherboardVersion;
            this.lblBiosReleaseDate = lblBiosReleaseDate;
            this.lblBiosVersion = lblBiosVersion;
            this.lblBiosVendor = lblBiosVendor;
            this.lblMotherboardSystemProductName = lblMotherboardSystemProductName;
            this.lblMotherboardSystemManufacturer = lblMotherboardSystemManufacturer;
            this.picMotherboard = picMotherboard;
        }

        public void update()
        {
            lblMotherboardManufacturer.Text = motherboard.BaseManufacturer;
            lblMotherboardProduct.Text = motherboard.BaseProduct;
            lblMotherboardVersion.Text = motherboard.BaseVersion;
            lblBiosReleaseDate.Text = motherboard.ReleaseDate;
            lblBiosVersion.Text = motherboard.BiosVersion;
            lblBiosVendor.Text = motherboard.BiosVendor;
            lblMotherboardSystemProductName.Text = motherboard.SystemProductName;
            lblMotherboardSystemManufacturer.Text = motherboard.SystemManufacturer;

            string caption = motherboard.BaseManufacturer.ToLower();
            if (caption.Contains("amd")) picMotherboard.Image = Resources.AMD;
            else if (caption.Contains("asrock")) picMotherboard.Image = Resources.ASROCK;
            else if (caption.Contains("asus")) picMotherboard.Image = Resources.ASUS;
            else if (caption.Contains("biostar")) picMotherboard.Image = Resources.BIOSTAR;
            else if (caption.Contains("dell")) picMotherboard.Image = Resources.DELL;
            else if (caption.Contains("gigabyte")) picMotherboard.Image = Resources.GIGABYTE;
            else if (caption.Contains("hp")) picMotherboard.Image = Resources.HP;
            else if (caption.Contains("intel")) picMotherboard.Image = Resources.INTEL;
            else if (caption.Contains("msi")) picMotherboard.Image = Resources.MSI;
            else if (caption.Contains("nvidia")) picMotherboard.Image = Resources.NVIDIA;
        }
    }
}
