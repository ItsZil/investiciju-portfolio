using MySqlConnector;
using Microsoft.AspNet.Identity;
using investiciju_portfolio.Utilities;

namespace investiciju_portfolio.Classes
{
    /// <summary>
    /// Class to handle registration of new users.
    /// </summary>
    internal static class Login
    {
        /// <summary>
        /// Checks if the user's password is correct.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">User password hash</param>
        /// <returns>True if logged in successfully, false otherwise.</returns>
        public static bool CheckLogin(string username, string password)
        {
            bool passwordCorrect = VerifyPassword(username, password, true);
            if (passwordCorrect)
            {
                return true;
            }
            else
                System.Windows.Forms.MessageBox.Show("Invalid username and/or incorrect password.");
            return false;
        }

        /// <summary>
        /// Verifies if the password hash is correct.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">User password hash</param>
        /// <param name="setSettings">Whether to set local user settings</param>
        /// <returns>True if password is correct, false otherwise.</returns>
        public static bool VerifyPassword(string username, string password, bool setSettings)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            con = new MySqlConnection("server=localhost;user=investiciju_portfolio;password=ipprojektas#;database=investiciju_portfolio");
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM `users` where username='" + username + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                var passwordHasher = new PasswordHasher();
                var isVerified = passwordHasher.VerifyHashedPassword(dr["password"].ToString(), password) != PasswordVerificationResult.Failed;
                if (isVerified)
                {
                    if (setSettings)
                    {
                        // Set settings before logging in.
                        SettingsHandler.SetSettings(dr["username"].ToString(), dr["first_name"].ToString(), dr["surname"].ToString(), (int)dr["id"]);
                    }
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
