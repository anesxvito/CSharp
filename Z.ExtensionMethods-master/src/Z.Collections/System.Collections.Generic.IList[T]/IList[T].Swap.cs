using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Replaces all occurrences of a specified value in the list with a new value.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="list">The list to act on.</param>
    /// <param name="oldValue">The value to be replaced.</param>
    /// <param name="newValue">The value to replace with.</param>
    public static void Swap<T>(this IList<T> list, T oldValue, T newValue)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(list[i], oldValue))
            {
                list[i] = newValue;
            }
        }
    }
}
