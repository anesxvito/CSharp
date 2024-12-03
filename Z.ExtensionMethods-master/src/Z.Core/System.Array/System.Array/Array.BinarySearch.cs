using System;
using System.Collections;

public static partial class Extensions
{
    /// <summary>
    /// Searches an entire one-dimensional sorted array for a specific element using the default comparer.
    /// </summary>
    /// <param name="array">The sorted one-dimensional array to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <returns>
    /// The index of the specified value if found. 
    /// If not found, a negative number that is the bitwise complement of the index of the next element
    /// that is larger than the value or, if no such element exists, the bitwise complement of the index 
    /// past the last element in the array.
    /// </returns>
    public static int BinarySearch(this Array array, object value)
    {
        return Array.BinarySearch(array, value);
    }

    /// <summary>
    /// Searches a range of elements in a one-dimensional sorted array for a specific element using the default comparer.
    /// </summary>
    /// <param name="array">The sorted one-dimensional array to search.</param>
    /// <param name="index">The starting index of the range to search.</param>
    /// <param name="length">The length of the range to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <returns>
    /// The index of the specified value if found. 
    /// If not found, a negative number that is the bitwise complement of the index of the next element
    /// that is larger than the value or, if no such element exists, the bitwise complement of the index 
    /// past the last element in the range.
    /// </returns>
    public static int BinarySearch(this Array array, int index, int length, object value)
    {
        return Array.BinarySearch(array, index, length, value);
    }

    /// <summary>
    /// Searches an entire one-dimensional sorted array for a specific element using the specified comparer.
    /// </summary>
    /// <param name="array">The sorted one-dimensional array to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <param name="comparer">
    /// The comparer to use when comparing elements or null to use the default comparer for each element type.
    /// </param>
    /// <returns>
    /// The index of the specified value if found. 
    /// If not found, a negative number that is the bitwise complement of the index of the next element
    /// that is larger than the value or, if no such element exists, the bitwise complement of the index 
    /// past the last element in the array.
    /// </returns>
    public static int BinarySearch(this Array array, object value, IComparer comparer)
    {
        return Array.BinarySearch(array, value, comparer);
    }

    /// <summary>
    /// Searches a range of elements in a one-dimensional sorted array for a specific element using the specified comparer.
    /// </summary>
    /// <param name="array">The sorted one-dimensional array to search.</param>
    /// <param name="index">The starting index of the range to search.</param>
    /// <param name="length">The length of the range to search.</param>
    /// <param name="value">The object to search for.</param>
    /// <param name="comparer">
    /// The comparer to use when comparing elements or null to use the default comparer for each element type.
    /// </param>
    /// <returns>
    /// The index of the specified value if found. 
    /// If not found, a negative number that is the bitwise complement of the index of the next element
    /// that is larger than the value or, if no such element exists, the bitwise complement of the index 
    /// past the last element in the range.
    /// </returns>
    public static int BinarySearch(this Array array, int index, int length, object value, IComparer comparer)
    {
        return Array.BinarySearch(array, index, length, value, comparer);
    }
}
