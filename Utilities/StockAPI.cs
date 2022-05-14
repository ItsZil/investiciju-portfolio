﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Microsoft.Data.Analysis;


namespace investiciju_portfolio
{
    public class StockAPI
    {
        //ESVY1L813KK0BO7V
       
        private string _apiKey;

        public StockAPI(string apiKey = "ESVY1L813KK0BO7V")
        {
            this._apiKey = apiKey;
        }

        /// <summary>
        /// Saves stock's data to csv file
        /// </summary>
        /// <param name="symbol"> stock's ticker </param>
        public void SaveCSVFromURL(string symbol)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://" + $@"www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={this._apiKey}&datatype=csv");
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
        public double getPrice(string stock, int rowsInd)
        {
            SaveCSVFromURL(stock);


            DataFrame df = DataFrame.LoadCsv("stockdata.csv");

            DataFrameRow row = df.Rows[rowsInd];

            double price = Convert.ToDouble(row[1]);
            return price;
        }
    }
}