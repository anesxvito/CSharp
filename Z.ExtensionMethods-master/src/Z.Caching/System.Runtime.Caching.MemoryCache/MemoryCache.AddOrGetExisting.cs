using System;
using System.Runtime.Caching;

public static partial class Extensions
{
    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, TValue value)
    {
        var item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;
        return (TValue)item;
    }

    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory)
    {
        var lazy = new Lazy<TValue>(() => valueFactory(key));
        var item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;
        return item.Value;
    }

    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory, CacheItemPolicy policy, string regionName = null)
    {
        var lazy = new Lazy<TValue>(() => valueFactory(key));
        var item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, policy, regionName) ?? lazy;
        return item.Value;
    }

    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory, DateTimeOffset absoluteExpiration, string regionName = null)
    {
        var lazy = new Lazy<TValue>(() => valueFactory(key));
        var item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, absoluteExpiration, regionName) ?? lazy;
        return item.Value;
    }
}
