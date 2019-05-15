using DDD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new Money(100m, Currency.Mxm);
            var moneyUsd = Money.ToUsd(money.Amount, DateTime.Now, new ExchangeRateFake());
            var moneyCad = Money.ToCad(money.Amount, DateTime.Now, new ExchangeRateFake());
            var moneyEur = Money.ToEur(money.Amount, DateTime.Now, new ExchangeRateFake());

            Console.WriteLine($"Money: ${money.Amount} - {money.Currency.CurrencyId}");
            Console.WriteLine($"Money: ${moneyUsd.Amount} - {moneyUsd.Currency.CurrencyId}");
            Console.WriteLine($"Money: ${moneyCad.Amount} - {moneyCad.Currency.CurrencyId}");
            Console.WriteLine($"Money: ${moneyEur.Amount} - {moneyEur.Currency.CurrencyId}");

            Console.ReadKey();
        }
    }

    public class ExchangeRateFake : IExchangeRate
    {
        private readonly List<ExchangeRate> _currencies = new List<ExchangeRate>
        {
            new ExchangeRate {Value = 10.5m },
        };

        public ExchangeRate FindExchangeRate(CurrencyType currencyType, DateTime actionDate)
        {
            return _currencies.FirstOrDefault();
        }
    }
}
