using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Removes the specified value from the collection if it exists.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to act on.</param>
    /// <param name="value">The value to remove if it exists in the collection.</param>
    public static void RemoveIfContains<T>(this ICollection<T> collection, T value)
    {
        if (collection.Contains(value))
        {
            collection.Remove(value);
        }
    }
}
