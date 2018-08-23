using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AMZ", "Amazon");
            stocks.Add("NKE", "NIKE");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "AMZ", shares: 32, price: 17.87));
            purchases.Add((ticker: "CAT", shares: 80, price: 19.02));

            Dictionary<string, double> portfolio = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                string FullCompanyName = stocks[purchase.ticker];
                // Does the company name key already exist in the report dictionary?
                if (portfolio.ContainsKey(purchase.ticker))
                {
                    portfolio[FullCompanyName] += purchase.shares * purchase.price;
                } else {
                    portfolio[FullCompanyName] = purchase.shares * purchase.price;
                }
                // If it does, update the total valuation

                // If not, add the new key and set its value
            }
            foreach (KeyValuePair<string, double> stock in portfolio)
            {
                Console.WriteLine($"I own {stock.Key} stock for a total of {stock.Value} ");
            }
        }
    }
}
