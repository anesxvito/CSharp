using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Determines whether the collection contains all the specified values.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to act on.</param>
    /// <param name="values">An array of values to check for in the collection.</param>
    /// <returns>True if the collection contains all specified values; otherwise, false.</returns>
    public static bool ContainsAll<T>(this ICollection<T> collection, params T[] values)
    {
        foreach (var value in values)
        {
            if (!collection.Contains(value))
            {
                return false;
            }
        }

        return true;
    }
}
