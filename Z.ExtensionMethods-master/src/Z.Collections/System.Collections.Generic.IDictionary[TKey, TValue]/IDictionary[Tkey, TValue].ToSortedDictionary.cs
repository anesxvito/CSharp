using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Converts the dictionary to a <see cref="SortedDictionary{TKey, TValue}"/>.
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to convert.</param>
    /// <returns>A <see cref="SortedDictionary{TKey, TValue}"/> containing the same key-value pairs as the original dictionary.</returns>
    public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
    {
        return new SortedDictionary<TKey, TValue>(dictionary);
    }

    /// <summary>
    /// Converts the dictionary to a <see cref="SortedDictionary{TKey, TValue}"/> using the specified comparer.
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to convert.</param>
    /// <param name="comparer">The comparer to use for sorting keys.</param>
    /// <returns>A <see cref="SortedDictionary{TKey, TValue}"/> containing the same key-value pairs as the original dictionary, sorted using the specified comparer.</returns>
    public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer)
    {
        return new SortedDictionary<TKey, TValue>(dictionary, comparer);
    }
}
