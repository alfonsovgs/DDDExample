using DDD.Framework;

namespace DDD.Domain
{
    public class ExchangeRate : Value<ExchangeRate>
    {
        public decimal Value { get; set; }
    }
}