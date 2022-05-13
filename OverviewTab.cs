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
        //API:ESVY1L813KK0BO7V
        public OverviewTab()
        {
            StockAPI conn = new StockAPI("ESVY1L813KK0BO7V");
            double price = conn.getPrice("IBM",0);
            double price2DaysAgo = conn.getPrice("IBM", 2);

            InitializeComponent();
        }
    }
}
