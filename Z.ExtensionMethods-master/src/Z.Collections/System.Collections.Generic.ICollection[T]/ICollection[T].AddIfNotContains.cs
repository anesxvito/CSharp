using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Adds the specified value to the collection if it does not already contain it.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to act on.</param>
    /// <param name="value">The value to add if not already present.</param>
    /// <returns>True if the value was added; otherwise, false.</returns>
    public static bool AddIfNotContains<T>(this ICollection<T> collection, T value)
    {
        if (!collection.Contains(value))
        {
            collection.Add(value);
            return true;
        }

        return false;
    }
}
