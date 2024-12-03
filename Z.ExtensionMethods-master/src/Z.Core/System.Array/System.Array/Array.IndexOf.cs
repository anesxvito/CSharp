using System;

public static partial class Extensions
{
    /// <summary>
    /// Searches for the specified object and returns the index of the first occurrence within the entire one-dimensional array.
    /// </summary>
    /// <param name="array">The one-dimensional array to search.</param>
    /// <param name="value">The object to locate in the array.</param>
    /// <returns>
    /// The index of the first occurrence of the specified object within the array, if found; otherwise, the lower bound of the array minus 1.
    /// </returns>
    public static int IndexOf(this Array array, object value)
    {
        return Array.IndexOf(array, value);
    }

    /// <summary>
    /// Searches for the specified object and returns the index of the first occurrence within the range of elements in the array
    /// that extends from the specified starting index to the last element.
    /// </summary>
    /// <param name="array">The one-dimensional array to search.</param>
    /// <param name="value">The object to locate in the array.</param>
    /// <param name="startIndex">The zero-based starting index of the search.</param>
    /// <returns>
    /// The index of the first occurrence of the specified object within the range of elements, if found; otherwise, the lower bound of the array minus 1.
    /// </returns>
    public static int IndexOf(this Array array, object value, int startIndex)
    {
        return Array.IndexOf(array, value, startIndex);
    }

    /// <summary>
    /// Searches for the specified object and returns the index of the first occurrence within the range of elements in the array
    /// that starts at the specified index and contains the specified number of elements.
    /// </summary>
    /// <param name="array">The one-dimensional array to search.</param>
    /// <param name="value">The object to locate in the array.</param>
    /// <param name="startIndex">The zero-based starting index of the search.</param>
    /// <param name="count">The number of elements in the section to search.</param>
    /// <returns>
    /// The index of the first occurrence of the specified object within the range of elements, if found; otherwise, the lower bound of the array minus 1.
    /// </returns>
    public static int IndexOf(this Array array, object value, int startIndex, int count)
    {
        return Array.IndexOf(array, value, startIndex, count);
    }
}
