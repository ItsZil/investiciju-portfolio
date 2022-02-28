﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using investiciju_portfolio.Utilities;

namespace investiciju_portfolio
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //DatabaseConnection dbConnection = new DatabaseConnection();
            //bool test = dbConnection.OpenConnection();
            //dbConnection.TestConnection();
            Application.Run(new LoginForm());
        }
    }
}
