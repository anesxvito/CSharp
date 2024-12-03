using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Removes a range of values from the collection.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to remove values from.</param>
    /// <param name="values">An array of values to remove from the collection.</param>
    public static void RemoveRange<T>(this ICollection<T> collection, params T[] values)
    {
        foreach (var value in values)
        {
            collection.Remove(value);
        }
    }
}
