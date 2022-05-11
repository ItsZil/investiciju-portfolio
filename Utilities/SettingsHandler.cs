using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investiciju_portfolio.Utilities
{
    static internal class SettingsHandler
    {
        public static string GetUsername()
        {
            string username = Properties.Settings.Default.username;
            if (username.Length > 0)
            {
                return username;
            }
            else
            {
                return "N/A";
            }
        }

        public static string GetSurname()
        {
            string surname = Properties.Settings.Default.surname;
            if (surname.Length > 0)
            {
                return surname;
            }
            else
            {
                return "N/A";
            }
        }

        public static int GetID()
        {
            int id = Properties.Settings.Default.id;
            if (id > 0)
            {
                return id;
            }
            else
            {
                return -1;
            }
        }
    }
}
