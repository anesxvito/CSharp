using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Adds a collection of values to the collection only if they satisfy the specified predicate.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to act on.</param>
    /// <param name="predicate">A function to test each value before adding.</param>
    /// <param name="values">An array of values to potentially add to the collection.</param>
    public static void AddRangeIf<T>(this ICollection<T> collection, Func<T, bool> predicate, params T[] values)
    {
        foreach (var value in values)
        {
            if (predicate(value))
            {
                collection.Add(value);
            }
        }
    }
}
