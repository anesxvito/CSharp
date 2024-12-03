using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Removes an entry from the dictionary if the specified key exists.
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to act on.</param>
    /// <param name="key">The key to check and remove.</param>
    public static void RemoveIfContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
    {
        if (dictionary.ContainsKey(key))
        {
            dictionary.Remove(key);
        }
    }
}
