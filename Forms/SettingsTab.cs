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
    public partial class SettingsTab : UserControl
    {
        public SettingsTab()
        {
            InitializeComponent();
        }

        private void SettingsTab_Load(object sender, EventArgs e)
        {
            SettingsTab_UsernameDisplayLabel.Text = SettingsHandler.GetUsername();
            SettingsTab_NameDisplayLabel.Text = SettingsHandler.GetFirstName();
            SettingsTab_SurnameDisplayLabel.Text = SettingsHandler.GetSurname();
            SettingsTab_CurrencySelectionBox.Text = SettingsTab_CurrencySelectionBox.Items[Properties.Settings.Default.base_currency].ToString();
        }

        private void SettingsTab_SaveCurrencyButton_Click(object sender, EventArgs e)
        {
            int selection = SettingsTab_CurrencySelectionBox.SelectedIndex;
            if (selection != -1)
            {
                Properties.Settings.Default.base_currency = selection;
                Properties.Settings.Default.Save();
            }
        }

        private void SettingsTab_SavePWButton_Click(object sender, EventArgs e)
        {
            string oldPassword = SettingsTab_OldPWTextBox.Text;
            string newPassword = SettingsTab_NewPWTextBox.Text;
            string confirmNewPassword = SettingsTab_ConfirmNewPWTextBox.Text;

            if (oldPassword.Length < 1 || newPassword.Length < 1 || confirmNewPassword.Length < 1)
            {
                MessageBox.Show("Ensure all fields are filled.");
                return;
            }
            else if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password does not match confirmation password.");
                return;
            }
            else if (oldPassword == newPassword)
            {
                MessageBox.Show("New password matches old password.");
                return;
            }

            string username = Properties.Settings.Default.username;
            bool oldPasswordMatches = PasswordHandler.VerifyPassword(username, oldPassword);
            if (!oldPasswordMatches)
            {
                MessageBox.Show("Old password is incorrect.");
                return;
            }

            bool changedPassword = PasswordHandler.ChangePassword(oldPassword, newPassword);
            if (changedPassword)
            {
                MessageBox.Show("Password successfully changed.");
            }
            else
            {
                MessageBox.Show("Failed to change password.");
            }
        }
    }
}
