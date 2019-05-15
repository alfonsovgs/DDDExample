using System;

namespace DDD.Framework
{
    public abstract class Entity<TId> where TId : Value<TId>
    {
        public TId Id { get; protected set; }
    }
}
