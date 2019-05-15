using System;
using DDD.Framework;

namespace DDD.Domain
{
    public class Money : Value<Money>
    {
        public decimal Amount { get; private set; }
        public Currency Currency { get; private set; }

        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money ToUsd(decimal amount, DateTime actionDate, IExchangeRate exchangeRate)
        {
            var targetCurrency = exchangeRate.FindExchangeRate(CurrencyType.Usd, actionDate);
            var newAmount = amount / targetCurrency.Value;
            return new Money(decimal.Round(newAmount, Currency.Usd.DecimalPlaces), Currency.Usd);
        }

        public static Money ToCad(decimal amount, DateTime actionDate, IExchangeRate exchangeRate)
        {
            var targetCurrency = exchangeRate.FindExchangeRate(CurrencyType.Cad, actionDate);
            var newAmount = amount / targetCurrency.Value;
            return new Money(decimal.Round(newAmount, Currency.Cad.DecimalPlaces), Currency.Cad);
        }

        public static Money ToEur(decimal amount, DateTime actionDate, IExchangeRate exchangeRate)
        {
            var targetCurrency = exchangeRate.FindExchangeRate(CurrencyType.Eur, actionDate);
            var newAmount = amount / targetCurrency.Value;
            return new Money(decimal.Round(newAmount, Currency.Eur.DecimalPlaces), Currency.Eur);
        }
    }
}
