using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investiciju_portfolio.Utilities
{
    /// <summary>
    /// Class to speed up retrieval of settings.
    /// </summary>
    static internal class SettingsHandler
    {
        public static void SetSettings(string username, string first_name, string surname, int id)
        {
            Properties.Settings.Default.username = username;
            Properties.Settings.Default.first_name = first_name;
            Properties.Settings.Default.surname = surname;
            Properties.Settings.Default.id = id;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Retrieves the user's username.
        /// </summary>
        /// <returns>username</returns>
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

        /// <summary>
        /// Retrieves the user's first name.
        /// </summary>
        /// <returns>first name</returns>
        public static string GetFirstName()
        {
            string first_name = Properties.Settings.Default.first_name;
            if (first_name.Length > 0)
            {
                return first_name;
            }
            else
            {
                return "N/A";
            }
        }

        /// <summary>
        /// Retrieves the user's surname.
        /// </summary>
        /// <returns>surname</returns>
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

        /// <summary>
        /// Returns the user's database ID.
        /// </summary>
        /// <returns>id</returns>
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
