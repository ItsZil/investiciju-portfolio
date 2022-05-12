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
        /// Registers a new user.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Users password</param>
        /// <returns></returns>
        public static bool CheckLogin(string username, string password)
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
                        // Set settings before logging in.
                        SettingsHandler.SetSettings(dr["username"].ToString(), dr["first_name"].ToString(), dr["surname"].ToString(), (int)dr["id"]);
                        return true;
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Invalid username and/or incorrect password.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Invalid username and/or incorrect password.");
                }
                con.Close();

            return false;
        }
    }
}
