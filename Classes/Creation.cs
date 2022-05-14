using System;
using MySqlConnector;
using investiciju_portfolio.Utilities;
using System.Security.Cryptography;
using Microsoft.AspNet.Identity;

namespace investiciju_portfolio.Classes
{
    /// <summary>
    /// Class to handle adding stocks for users.
    /// </summary>
    internal static class Creation
    {
        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="ticker">stock name</param>
        /// <param name="count">stock purchased amount</param>
        /// <param name="purchasePrice">avg stock price when purchased</param>
        /// <param name="fkUser">user id who purchased the stock</param>
        /// <returns></returns>
        public static bool AddStock(string ticker, double count, double purchasePrice, int fkUser)
        {
            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO instruments (ticker, count, purchase_price, fk_user) VALUES (@ticker, @count, @purchase_price, @fk_user)"));
                command.Parameters.AddWithValue("@ticker", ticker);
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@purchase_price", purchasePrice);
                command.Parameters.AddWithValue("@fk_user", fkUser);
                dbConnection.ExecuteCommand(command);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       
    }
}
