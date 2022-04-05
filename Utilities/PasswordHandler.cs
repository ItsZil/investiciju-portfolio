using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace investiciju_portfolio.Utilities
{
    /// <summary>
    /// Static class containing methods to assist in hashing and unhashing passwords.
    /// </summary>
    static internal class PasswordHandler
    {
        /// <summary>
        /// Checks if a password meets the requirement of containing 1 number and 1 capital letter.
        /// </summary>
        /// <param name="password">The password string to check.</param>
        /// <returns>true if meets requirements, false otherwise.</returns>
        public static bool PasswordMeetsRequirements(string password)
        {
            return (password.Any(c => char.IsDigit(c))) &&
                password.Any(c => char.IsUpper(c)) &&
                password.Any(c => char.IsLower(c));
        }
    }
}
