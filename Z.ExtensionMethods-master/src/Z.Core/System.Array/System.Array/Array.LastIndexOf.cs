using System;

public static partial class Extensions
{
    /// <summary>
    /// Searches for the specified object and returns the index of the last occurrence within the entire one-dimensional array.
    /// </summary>
    /// <param name="array">The one-dimensional array to search.</param>
    /// <param name="value">The object to locate in the array.</param>
    /// <returns>
    /// The index of the last occurrence of the specified object within the array, if found; otherwise, the lower bound of the array minus 1.
    /// </returns>
    public static int LastIndexOf(this Array array, object value)
    {
        return Array.LastIndexOf(array, value);
    }

    /// <summary>
    /// Searches for the specified object and returns the index of the last occurrence within the range of elements
    /// in the array that extends from the first element to the specified index.
    /// </summary>
    /// <param name="array">The one-dimensional array to search.</param>
    /// <param name="value">The object to locate in the array.</param>
    /// <param name="startIndex">The zero-based starting index of the backward search.</param>
    /// <returns>
    /// The index of the last occurrence of the specified object within the range of elements, if found; otherwise, the lower bound of the array minus 1.
    /// </returns>
    public static int LastIndexOf(this Array array, object value, int startIndex)
    {
        return Array.LastIndexOf(array, value, startIndex);
    }

    /// <summary>
    /// Searches for the specified object and returns the index of the last occurrence within the range of elements
    /// in the array that contains the specified number of elements and ends at the specified index.
    /// </summary>
    /// <param name="array">The one-dimensional array to search.</param>
    /// <param name="value">The object to locate in the array.</param>
    /// <param name="startIndex">The zero-based starting index of the backward search.</param>
    /// <param name="count">The number of elements in the section to search.</param>
    /// <returns>
    /// The index of the last occurrence of the specified object within the range of elements, if found; otherwise, the lower bound of the array minus 1.
    /// </returns>
    public static int LastIndexOf(this Array array, object value, int startIndex, int count)
    {
        return Array.LastIndexOf(array, value, startIndex, count);
    }
}
