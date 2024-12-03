using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Adds a range of values to the collection if they are not already present.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to add values to.</param>
    /// <param name="values">An array of values to add if not already present.</param>
    public static void AddRangeIfNotContains<T>(this ICollection<T> collection, params T[] values)
    {
        foreach (var value in values)
        {
            if (!collection.Contains(value))
            {
                collection.Add(value);
            }
        }
    }
}
