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
            bool passwordCorrect = PasswordHandler.VerifyPassword(username, password, true);
            if (passwordCorrect)
            {
                return true;
            }
            else
                System.Windows.Forms.MessageBox.Show("Invalid username and/or incorrect password.");
            return false;
        }
    }
}
