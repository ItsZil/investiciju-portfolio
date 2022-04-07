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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm f2 = new RegistrationForm();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeWindow f3 = new HomeWindow();
            f3.ShowDialog();
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
