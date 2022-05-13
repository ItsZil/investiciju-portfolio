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

            if(!Registration.IsUsernameUnique(usernameText) && !PasswordHandler.PasswordMeetsRequirements(passwordText))
            {
                MessageBox.Show("Username is already taken. \n" + "Password must contain 8 symbols, atleast 1 digit and 1 capital letter.");
            }

            if (!Registration.IsUsernameUnique(usernameText))
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            if (!PasswordHandler.PasswordMeetsRequirements(passwordText))
            {
                MessageBox.Show("Password must contain 8 symbols, atleast 1 digit and 1 capital letter.");
                return;
            }

            bool registrationState = Registration.RegisterUser(usernameText, nameText, surnameText, passwordText);
            if(registrationState)
            {
                MessageBox.Show("Registration was succesful.");
                this.Close();
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_TurnOffButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationForm_ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
