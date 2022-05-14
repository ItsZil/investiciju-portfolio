using System;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNet.Identity;
using MySqlConnector;

namespace investiciju_portfolio.Utilities
{
    /// <summary>
    /// Static class containing methods to assist in editing and finding stocks
    /// </summary>
    static internal class StockHandler
    {
        /// <summary>
        /// Creates a new stock.
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

        /// <summary>
        /// Deletes the specified user's stock from the database.
        /// </summary>
        /// <param name="ticker">Instrument ticker</param>
        /// <param name="fkUser">User ID</param>
        /// <returns></returns>
        public static bool DeleteStock(string ticker, int fkUser)
        {
            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                MySqlCommand command = new MySqlCommand(String.Format("DELETE FROM instruments WHERE ticker=@ticker AND fk_user=@fk_user"));
                command.Parameters.AddWithValue("@ticker", ticker);
                command.Parameters.AddWithValue("@fk_user", fkUser);
                dbConnection.ExecuteCommand(command);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        /// <summary>
        /// Changes stock average price and/or the amount
        /// </summary>
        /// <param name="count">the amount of the stock</param>
        /// <param name="purchasePrice">the average price that user paid for stock</param>
        /// <param name="ticker">stock name</param>
        /// <returns></returns>
        public static bool EditStock(double count, double purchasePrice, string ticker)
        {
            int userId = Properties.Settings.Default.id;
            if (userId < 1)
                return false;
            if (!stockExists(ticker))
                return false;

            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE instruments SET count=@count, purchase_price=@purchase_price WHERE fk_user=@id AND ticker=@ticker"));
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@purchase_price", purchasePrice);
                command.Parameters.AddWithValue("@id", userId);
                command.Parameters.AddWithValue("@ticker", ticker);
                dbConnection.ExecuteCommand(command);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool stockExists(string ticker)
        {
            MySqlConnection con;
                MySqlCommand cmd;
                MySqlDataReader dr;
                con = new MySqlConnection("server=localhost;user=investiciju_portfolio;password=ipprojektas#;database=investiciju_portfolio");
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM `instruments` where ticker='" + ticker + "' AND fk_user='" + Properties.Settings.Default.id + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    var isVerified = (dr["ticker"].ToString() == ticker);
                    if (isVerified)
                    {
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
