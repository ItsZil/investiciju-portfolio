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
        bool exit;

        public LoginForm()
        {
            InitializeComponent();
            exit = true;
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
            exit = false;
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeWindow f3 = new HomeWindow();
            f3.ShowDialog();
        }
    }
}
