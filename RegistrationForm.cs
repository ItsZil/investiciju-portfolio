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
            string usernameText = RegistrationForm_UsernameTextBox.Text;
            string nameText = RegistrationForm_NameTextBox.Text;
            string surnameText = RegistrationForm_SurnameTextBox.Text;
            string passwordText = RegistrationForm_PasswordTextBox.Text;

            // IP-37 field verification: need to check if strings aren't empty, show errors

            if (!Registration.IsUsernameUnique(usernameText))
            { 
                // error message
                return;
            }

            if (!PasswordHandler.PasswordMeetsRequirements(passwordText))
            {
                // password does not contain at least 8 chars, or 1 capital letter, or 1 digit
                return;
            }

            bool registrationState = Registration.RegisterUser(usernameText, nameText, surnameText, passwordText);
            // check if registration is successful, show message if not
        }
    }
}
