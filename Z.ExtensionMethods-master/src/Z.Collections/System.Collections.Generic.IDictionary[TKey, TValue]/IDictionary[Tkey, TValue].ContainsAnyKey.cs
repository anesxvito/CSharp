using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Determines whether the dictionary contains any of the specified keys.
    /// </summary>
    /// <typeparam name="TKey">The type of the dictionary keys.</typeparam>
    /// <typeparam name="TValue">The type of the dictionary values.</typeparam>
    /// <param name="dictionary">The dictionary to check.</param>
    /// <param name="keys">An array of keys to check for in the dictionary.</param>
    /// <returns>True if the dictionary contains any of the specified keys; otherwise, false.</returns>
    public static bool ContainsAnyKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, params TKey[] keys)
    {
        foreach (var key in keys)
        {
            if (dictionary.ContainsKey(key))
            {
                return true;
            }
        }

        return false;
    }
}
