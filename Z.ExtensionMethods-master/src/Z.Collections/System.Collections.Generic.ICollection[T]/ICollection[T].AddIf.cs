using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Adds the specified value to the collection if it satisfies the given predicate.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to act on.</param>
    /// <param name="predicate">A function to test the value.</param>
    /// <param name="value">The value to add if the predicate returns true.</param>
    /// <returns>True if the value was added; otherwise, false.</returns>
    public static bool AddIf<T>(this ICollection<T> collection, Func<T, bool> predicate, T value)
    {
        if (predicate(value))
        {
            collection.Add(value);
            return true;
        }

        return false;
    }
}
