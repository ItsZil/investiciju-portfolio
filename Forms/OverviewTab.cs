using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace investiciju_portfolio
{
    public partial class OverviewTab : UserControl
    {
        public OverviewTab()
        {
            InitializeComponent();
        }

        private void OverviewTab_Load(object sender, EventArgs e)
        {
            OverviewTab_InstrumentActionPanel.SendToBack();
        }

        private void OverviewTab_CreateButton_Click(object sender, EventArgs e)
        {
            OverviewTab_InstrumentActionPanel.BringToFront();
        }

        private void OverviewTab_EditButton_Click(object sender, EventArgs e)
        {

            OverviewTab_InstrumentActionPanel.BringToFront();
        }

        private void OverviewTab_RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void OverviewTab_ConfirmButton_Click(object sender, EventArgs e)
        {
            string Ticker = OverviewTab_TickerTextBox.Text;
            double Count = Convert.ToDouble(OverviewTab_CountTextBox.Text);
            double AvgPrice = Convert.ToDouble(OverviewTab_AvgPriceTextBox);

        }

        private void Overviewtab_InstrumentsActionPanel_CloseButton_Click(object sender, EventArgs e)
        {
            OverviewTab_InstrumentActionPanel.SendToBack();
        }
    }
}
