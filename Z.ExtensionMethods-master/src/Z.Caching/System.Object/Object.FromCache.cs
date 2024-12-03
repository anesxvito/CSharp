using System;
using System.Linq.Expressions;
using System.Runtime.Caching;

public static partial class Extensions
{
    public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key, TValue value)
    {
        var item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;
        return (TValue)item;
    }

    public static TValue FromCache<T, TValue>(this T @this, string key, TValue value)
    {
        return @this.FromCache(MemoryCache.Default, key, value);
    }

    public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key, Expression<Func<T, TValue>> valueFactory)
    {
        var lazy = new Lazy<TValue>(() => valueFactory.Compile()(@this));
        var item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;
        return item.Value;
    }

    public static TValue FromCache<T, TValue>(this T @this, string key, Expression<Func<T, TValue>> valueFactory)
    {
        return @this.FromCache(MemoryCache.Default, key, valueFactory);
    }

    public static TValue FromCache<TKey, TValue>(this TKey @this, Expression<Func<TKey, TValue>> valueFactory)
    {
        var key = $"Z.Caching.FromCache;{typeof(TKey).FullName};{valueFactory}";
        return @this.FromCache(MemoryCache.Default, key, valueFactory);
    }

    public static TValue FromCache<TKey, TValue>(this TKey @this, MemoryCache cache, Expression<Func<TKey, TValue>> valueFactory)
    {
        var key = $"Z.Caching.FromCache;{typeof(TKey).FullName};{valueFactory}";
        return @this.FromCache(cache, key, valueFactory);
    }
}
