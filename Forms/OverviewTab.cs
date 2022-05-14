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
using MySqlConnector;

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
            double value = 0;
            using (var conn = new MySqlConnection("server=localhost;user=investiciju_portfolio;password=ipprojektas#;database=investiciju_portfolio"))
            {
                MySqlDataReader dr;
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM instruments where fk_user='" + Properties.Settings.Default.id + "'", conn))
                {
                    
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(dr["ticker"].ToString());
                        listViewItem.Text = dr["ticker"].ToString();
                        StockAPI stockAPI = new StockAPI();
                        double RealPrice = stockAPI.getPrice(dr["ticker"].ToString(), 0);
                        listViewItem.SubItems.Add(RealPrice.ToString());
                        StockListView.Items.Add(listViewItem);
                        value += RealPrice * Int32.Parse(dr["count"].ToString());
                    }
                   
                }
            }

            OverviewTab_EquityValueLabel.Text = Math.Round(value, 3).ToString();



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
                MessageBox.Show("Ensure all fields are filled in.");
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
                    
                    if (!stockExists)
                    {
                        bool createdStock = Creation.AddStock(Ticker, Count, AvgPrice, Properties.Settings.Default.id);
                        if (createdStock)
                        {
                            StockAPI stockAPI = new StockAPI();
                            double RealPrice = stockAPI.getPrice(Ticker, 0);
                            listViewItem.SubItems.Add(Math.Round(RealPrice, 3).ToString());
                            StockListView.Items.Add(listViewItem);

                            OverviewTab_TickerTextBox.Text = string.Empty;
                            OverviewTab_CountTextBox.Text = string.Empty;
                            OverviewTab_AvgPriceTextBox.Text = string.Empty;

                            OverviewTab_EquityValueLabel.Text = Math.Round(EquityHandler.countValue(), 3).ToString();
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
                        OverviewTab_EquityValueLabel.Text = Math.Round(EquityHandler.countValue(), 3).ToString();
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
