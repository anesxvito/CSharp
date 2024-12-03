using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Removes the specified value from the collection if it satisfies the given predicate.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to act on.</param>
    /// <param name="value">The value to potentially remove.</param>
    /// <param name="predicate">A function to test the value before removal.</param>
    public static void RemoveIf<T>(this ICollection<T> collection, T value, Func<T, bool> predicate)
    {
        if (predicate(value))
        {
            collection.Remove(value);
        }
    }
}
