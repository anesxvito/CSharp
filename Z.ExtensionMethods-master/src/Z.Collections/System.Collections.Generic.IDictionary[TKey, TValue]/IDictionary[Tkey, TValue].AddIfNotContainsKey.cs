using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Adds the specified key and value to the dictionary if the key does not already exist.
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to act on.</param>
    /// <param name="key">The key to add.</param>
    /// <param name="value">The value to add.</param>
    /// <returns>True if the key-value pair was added; otherwise, false.</returns>
    public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
    {
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, value);
            return true;
        }

        return false;
    }

    /// <summary>
    /// Adds the specified key and value to the dictionary if the key does not already exist, using a value factory function.
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to act on.</param>
    /// <param name="key">The key to add.</param>
    /// <param name="valueFactory">A function that provides the value to add if the key does not exist.</param>
    /// <returns>True if the key-value pair was added; otherwise, false.</returns>
    public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueFactory)
    {
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, valueFactory());
            return true;
        }

        return false;
    }

    /// <summary>
    /// Adds the specified key and value to the dictionary if the key does not already exist, using a value factory function that takes the key as a parameter.
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to act on.</param>
    /// <param name="key">The key to add.</param>
    /// <param name="valueFactory">A function that provides the value to add if the key does not exist, taking the key as a parameter.</param>
    /// <returns>True if the key-value pair was added; otherwise, false.</returns>
    public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> valueFactory)
    {
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, valueFactory(key));
            return true;
        }

        return false;
    }
}
