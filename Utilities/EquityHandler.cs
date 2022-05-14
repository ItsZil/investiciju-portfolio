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
        /// Changes stock average price and/or the amount
        /// </summary>
        /// <returns></returns>
        public static double countValue()
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
                        StockAPI stockAPI = new StockAPI();
                        double RealPrice = stockAPI.getPrice(dr["ticker"].ToString(), 0);
                        value += RealPrice * Int32.Parse(dr["count"].ToString());
                    }
                    return value;

                }
            }
            

        }
        
    }
}
