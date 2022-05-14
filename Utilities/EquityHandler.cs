using System;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNet.Identity;
using MySqlConnector;
using System.Windows.Forms;

namespace investiciju_portfolio.Utilities
{
    /// <summary>
    /// Static class containing methods to assist in calculating equity value
    /// </summary>
    static internal class EquityHandler
    {
        /// <summary>
        /// Calculates the total value of the user's instruments.
        /// </summary>
        /// <returns></returns>
        public static double CountValue()
        {
            double value = 0;
            using (var conn = new MySqlConnection("server=localhost;user=investiciju_portfolio;password=ipprojektas#;database=investiciju_portfolio"))
            {
                MySqlDataReader dr;
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM instruments where fk_user='" + Properties.Settings.Default.id + "'", conn))
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        double RealPrice = StockAPI.GetPrice(dr["ticker"].ToString(), 0);
                        value += RealPrice * Int32.Parse(dr["count"].ToString());
                    }
                    return value;

                }
            }
        }

        /// <summary>
        /// Calculates the total value of the user's instruments for today - days.
        /// </summary>
        /// <param name="days">Number of day to look back at</param>
        /// <returns></returns>
        public static double[] CountValue(int days)
        {
            double[] values = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            using (var conn = new MySqlConnection("server=localhost;user=investiciju_portfolio;password=ipprojektas#;database=investiciju_portfolio"))
            {
                MySqlDataReader dr;
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM instruments where fk_user='" + Properties.Settings.Default.id + "'", conn))
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        double[] prices = StockAPI.GetPrices(dr["ticker"].ToString(), 7);
                        for (int i = 0; i < 7; i++)
                        {
                            values[i] += prices[i] * Int32.Parse(dr["count"].ToString());
                        }
                    }
                    return values;

                }
            }
        }

    }
}
