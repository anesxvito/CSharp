using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Adds the specified range of values to the collection.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to act on.</param>
    /// <param name="values">An array of values to add to the collection.</param>
    public static void AddRange<T>(this ICollection<T> collection, params T[] values)
    {
        foreach (var value in values)
        {
            collection.Add(value);
        }
    }
}
