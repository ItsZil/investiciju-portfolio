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
    public partial class SettingsTab : UserControl
    {
        public SettingsTab()
        {
            InitializeComponent();
        }

        private void SettingsTab_Load(object sender, EventArgs e)
        {
            //SettingsTab_UsernameDisplayLabel.Text = 
            //SettingsTab_NameDisplayLabel.Text = 
            //SettingsTab_SurnameDisplayLabel.Text = 
            SettingsTab_CurrencySelectionBox.Text = SettingsTab_CurrencySelectionBox.Items[0].ToString();
        }
    }
}
