using investiciju_portfolio.Classes;
using investiciju_portfolio.Utilities;
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
        private bool CreateIsClicked = false;
        private bool EditIsClicked = false;
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
            if (!CreateIsClicked)
            {
                OverviewTab_InstrumentActionPanel.BringToFront();
                CreateIsClicked = true;
                EditIsClicked = false;
            }
            else
            {
                OverviewTab_InstrumentActionPanel.SendToBack();
                CreateIsClicked = false;
            }
        }

        private void OverviewTab_EditButton_Click(object sender, EventArgs e)
        {
            if (!EditIsClicked)
            {
                OverviewTab_InstrumentActionPanel.BringToFront();
                EditIsClicked = true;
                CreateIsClicked = false;
            }
            else
            {
                OverviewTab_InstrumentActionPanel.SendToBack();
                EditIsClicked = false;
            }
        }

        private void OverviewTab_RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void OverviewTab_ConfirmButton_Click(object sender, EventArgs e)
        {

            if (OverviewTab_TickerTextBox.Text == string.Empty || OverviewTab_CountTextBox.Text == string.Empty || OverviewTab_AvgPriceTextBox.Text == String.Empty)
                MessageBox.Show("Write in all of boxes");
            else
            {
                string Ticker = OverviewTab_TickerTextBox.Text;
                double Count = Convert.ToDouble(OverviewTab_CountTextBox.Text);
                double AvgPrice = Convert.ToDouble(OverviewTab_AvgPriceTextBox.Text);
                ListViewItem listViewItem = new ListViewItem(Ticker);
                if (CreateIsClicked)
                {
                    listViewItem.Text = Ticker;


                    bool stockExists = StockHandler.stockExists(Ticker);
                    bool createdStock = Creation.AddStock(Ticker, Count, AvgPrice, Properties.Settings.Default.id);
                    if (!stockExists)
                    {
                        if (createdStock)
                        {
                            StockAPI stockAPI = new StockAPI();
                            double RealPrice = stockAPI.getPrice(Ticker, 0);
                            listViewItem.SubItems.Add(RealPrice.ToString());
                            StockListView.Items.Add(listViewItem);

                            OverviewTab_TickerTextBox.Text = string.Empty;
                            OverviewTab_CountTextBox.Text = string.Empty;
                            OverviewTab_AvgPriceTextBox.Text = string.Empty;

                            MessageBox.Show(Ticker + " stock successfully added.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add " + Ticker + " stock.");
                        }
                    }
                    else
                        MessageBox.Show(Ticker + " stock already exists.");
                }

                if (EditIsClicked)
                {

                    bool editedStock = StockHandler.EditStock(Count, AvgPrice, Ticker);
                    if (editedStock)
                    {
                        OverviewTab_TickerTextBox.Text = string.Empty;
                        OverviewTab_CountTextBox.Text = string.Empty;
                        OverviewTab_AvgPriceTextBox.Text = string.Empty;

                        MessageBox.Show(Ticker + " stock successfully edited.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to edit " + Ticker + " stock.");
                    }
                }
            }
        }
    }
}
