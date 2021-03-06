using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Microsoft.Data.Analysis;


namespace investiciju_portfolio
{
    /// <summary>
    /// API class to retrieve stock prices.
    /// </summary>
    public static class StockAPI
    {
        private static string _apiKey = "ESVY1L813KK0BO7V";

        /// <summary>
        /// Saves stock's data to csv file
        /// </summary>
        /// <param name="symbol"> stock's ticker </param>
        public static void SaveCSVFromURL(string symbol)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://" + $@"www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={_apiKey}&datatype=csv");
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();
            File.WriteAllText("stockdata.csv", results);

        }


        /// <summary>
        /// Returns price from csv file
        /// </summary>
        /// <param name="stock"> stock's ticker </param>
        /// <param name="rowsInd"> number of days passed from today (Assumption) </param>
        /// <returns></returns>
        public static double GetPrice(string stock, int rowsInd)
        {
            SaveCSVFromURL(stock);


            DataFrame df = DataFrame.LoadCsv("stockdata.csv");

            DataFrameRow row = df.Rows[rowsInd];

            double price = Convert.ToDouble(row[1]);
            return price;
        }

        /// <summary>
        /// Returns a double list of prices for multiple days.
        /// </summary>
        /// <param name="stock">The stock's ticker</param>
        /// <param name="dayCount">Number of days</param>
        /// <returns></returns>
        public static double[] GetPrices(string stock, int dayCount)
        {
            double[] prices = new double[dayCount];
            SaveCSVFromURL(stock);

            DataFrame df = DataFrame.LoadCsv("stockdata.csv");
            for (int i = 0; i < dayCount; i++)
            {
                DataFrameRow row = df.Rows[7 - i];
                prices[i] = Convert.ToDouble(row[1]);
            }
            return prices;
        }

    }
}
