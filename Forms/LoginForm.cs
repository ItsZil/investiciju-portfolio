using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using investiciju_portfolio.Utilities;
using investiciju_portfolio.Classes;

namespace investiciju_portfolio
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            //Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        }

        private void LoginForm_RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm f2 = new RegistrationForm();
            f2.ShowDialog();
        }

        private void LoginForm_LoginButton_Click(object sender, EventArgs e)
        {
            string usernameText = LoginForm_UsernameTextBox.Text;
            string passwordText = LoginForm_PasswordTextBox.Text;
            bool loginState = Login.CheckLogin(usernameText, passwordText);
            //if (loginState)
            //{
                HomeWindow f3 = new HomeWindow();
                f3.ShowDialog();
            //}
               
        }

        private void LoginForm_TurnOffButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void placeholderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
