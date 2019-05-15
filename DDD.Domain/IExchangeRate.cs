using System;

namespace DDD.Domain
{
    public interface IExchangeRate
    {
        ExchangeRate FindExchangeRate(CurrencyType currencyType, DateTime actionDate);
    }
}