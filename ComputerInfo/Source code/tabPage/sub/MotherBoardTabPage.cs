using ComputerInfo.Source_code.tabPage;
using ComputerInfo.WMI;
using MetroSuite;

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
        private readonly MetroLabel lblMotherboardSystemVersion;

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
            MetroLabel lblMotherboardSystemVersion
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
            this.lblMotherboardSystemVersion = lblMotherboardSystemVersion;
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
            lblMotherboardSystemVersion.Text = motherboard.SystemVersion;
        }
    }
}
