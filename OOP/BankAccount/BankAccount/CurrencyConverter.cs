using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class CurrencyConverter
    {
        private static readonly Dictionary<string, decimal> currencyRates = new Dictionary<string, decimal>
        {
            { "BGN", 1m },
            { "EUR", 0.51m },
            { "USD", 0.55m },
            { "JPY", 83.75m },
            { "RUB", 50.67m }
        };

        private const decimal FeeRate = 0.02m;

        public static decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            if (fromCurrency == toCurrency)
            {
                return amount;
            }
            decimal convertedAmount = amount * (currencyRates[toCurrency] / currencyRates[fromCurrency]);
            return Math.Round(convertedAmount - convertedAmount * FeeRate);
        }
    }
}
