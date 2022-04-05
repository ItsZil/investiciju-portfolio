using System;
using System.Windows.Forms;
using investiciju_portfolio.Utilities;
using investiciju_portfolio.Classes;

namespace investiciju_portfolio
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_RegisterButton_Click(object sender, EventArgs e)
        {
            string usernameText = RegistrationForm_NameTextBox.Text;
            string nameText = RegistrationForm_NameTextBox.Text;
            string surnameText = RegistrationForm_SurnameTextBox.Text;
            string passwordText = RegistrationForm_PasswordTextBox.Text;

            // IP-37 field verification: need to check if strings aren't empty, show errors
            if (PasswordHandler.PasswordMeetsRequirements(passwordText))
            {
                bool registrationState = Registration.RegisterUser(usernameText, nameText, surnameText, passwordText);
            }
            else
            {
                // password does not contain at least 8 chars, or 1 capital letter, or 1 digit
            }
        }
    }
}
