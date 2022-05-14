using System;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNet.Identity;
using MySqlConnector;

namespace investiciju_portfolio.Utilities
{
    /// <summary>
    /// Static class containing methods to assist in hashing and unhashing passwords.
    /// </summary>
    static internal class StockHandler
    {
        /// <summary>
        /// Changes stock average price and/or the amount
        /// </summary>
        /// <param name="count"></param>
        /// <param name="purchasePrice"></param>
        /// <param name="ticker"></param>
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
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE instruments SET count=@count, purchase_price=@purchase_price WHERE id=@id AND ticker=@ticker"));
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
                cmd.CommandText = "SELECT * FROM `instruments` where ticker='" + ticker + "'";
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
