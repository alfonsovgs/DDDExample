using DDD.Framework;

namespace DDD.Domain
{
    public class Currency : Value<Currency>
    {
        public int CurrencyId { get; private set; }
        public int DecimalPlaces { get; private set; }
        public bool Active { get; private set; }

        public static Currency Mxm = new Currency { Active = false, CurrencyId = 1, DecimalPlaces = 2 };
        public static Currency Usd = new Currency { Active = false, CurrencyId = 2, DecimalPlaces = 2 };
        public static Currency Eur = new Currency { Active = false, CurrencyId = 3, DecimalPlaces = 2 };
        public static Currency Cad = new Currency { Active = false, CurrencyId = 4, DecimalPlaces = 2 };
        public static Currency None = new Currency { Active = false };
    }
}