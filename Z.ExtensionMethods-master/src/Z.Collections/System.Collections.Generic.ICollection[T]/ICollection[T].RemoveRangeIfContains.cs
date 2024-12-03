using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Removes a range of items from the collection if they exist in the collection.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to remove items from.</param>
    /// <param name="values">An array of items to remove if they exist in the collection.</param>
    public static void RemoveRangeIfContains<T>(this ICollection<T> collection, params T[] values)
    {
        foreach (var value in values)
        {
            if (collection.Contains(value))
            {
                collection.Remove(value);
            }
        }
    }
}
