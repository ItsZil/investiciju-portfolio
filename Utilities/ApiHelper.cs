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
    public class ApiHelper
    {
        //ESVY1L813KK0BO7V
       
        private string _apiKey;

        public ApiHelper(string apiKey)
        {
            this._apiKey = apiKey;
        }

        public void SaveCSVFromURL(string symbol)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://" + $@"www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={this._apiKey}&datatype=csv");
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();
            File.WriteAllText("stockdata.csv", results);

        }

        public double getPrice(string stock)
        {
            SaveCSVFromURL(stock);


            DataFrame df = DataFrame.LoadCsv("stockdata.csv");

            DataFrameRow row = df.Rows[0];

            string price = row[1].ToString();
            return 2;
        }
    }
}
