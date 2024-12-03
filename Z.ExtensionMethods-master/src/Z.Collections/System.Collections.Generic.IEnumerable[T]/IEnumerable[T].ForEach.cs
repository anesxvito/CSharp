using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Executes the specified action on each element in the enumerable.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to act on.</param>
    /// <param name="action">The action to perform on each element.</param>
    /// <returns>The original enumerable after performing the action on each element.</returns>
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
        {
            action(item);
        }
        return source;
    }

    /// <summary>
    /// Executes the specified action on each element in the enumerable, providing the index of each element.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to act on.</param>
    /// <param name="action">The action to perform on each element, with the index provided.</param>
    /// <returns>The original enumerable after performing the action on each element.</returns>
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
    {
        int index = 0;
        foreach (var item in source)
        {
            action(item, index++);
        }
        return source;
    }
}
