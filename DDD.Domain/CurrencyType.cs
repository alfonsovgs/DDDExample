using System;
using System.Collections.Generic;
using System.Text;
using DDD.Framework;

namespace DDD.Domain
{
    public class CurrencyType : Enumeration
    {
        public static CurrencyType Mxn = new CurrencyType(1, nameof(Mxn));
        public static CurrencyType Usd = new CurrencyType(2, nameof(Usd));
        public static CurrencyType Cad = new CurrencyType(3, nameof(Cad));
        public static CurrencyType Eur = new CurrencyType(4, nameof(Eur));
        public static CurrencyType None = new CurrencyType(0, nameof(Eur));

        protected CurrencyType(int id, string name) : base(id, name)
        {
        }
    }
}
