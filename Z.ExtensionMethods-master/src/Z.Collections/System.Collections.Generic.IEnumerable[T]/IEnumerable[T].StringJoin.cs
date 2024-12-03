using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Concatenates all the elements of an <see cref="IEnumerable{T}"/>, using the specified string separator between each element.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable that contains the elements to concatenate.</param>
    /// <param name="separator">
    /// The string to use as a separator. The separator is included in the returned string only if the enumerable has more than one element.
    /// </param>
    /// <returns>
    /// A string that consists of the elements in the enumerable delied by the separator string. If the enumerable is empty, the method returns <see cref="string.Empty"/>.
    /// </returns>
    public static string StringJoin<T>(this IEnumerable<T> source, string separator)
    {
        return string.Join(separator, source);
    }

    /// <summary>
    /// Concatenates all the elements of an <see cref="IEnumerable{T}"/>, using the specified character separator between each element.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable that contains the elements to concatenate.</param>
    /// <param name="separator">
    /// The character to use as a separator. The separator is included in the returned string only if the enumerable has more than one element.
    /// </param>
    /// <returns>
    /// A string that consists of the elements in the enumerable delied by the separator character. If the enumerable is empty, the method returns <see cref="string.Empty"/>.
    /// </returns>
    public static string StringJoin<T>(this IEnumerable<T> source, char separator)
    {
        return string.Join(separator.ToString(), source);
    }
}
