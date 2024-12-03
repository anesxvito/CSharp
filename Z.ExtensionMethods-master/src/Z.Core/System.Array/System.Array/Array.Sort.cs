using System;
using System.Collections;

public static partial class Extensions
{
    /// <summary>
    /// Sorts the elements in an entire one-dimensional array using the default comparer.
    /// </summary>
    /// <param name="array">The one-dimensional array to sort.</param>
    public static void Sort(this Array array)
    {
        Array.Sort(array);
    }

    /// <summary>
    /// Sorts a pair of one-dimensional arrays (keys and corresponding items) based on the keys using the default comparer.
    /// </summary>
    /// <param name="array">The one-dimensional array of keys to sort.</param>
    /// <param name="items">
    /// The one-dimensional array of items that correspond to each of the keys. This array is sorted in parallel with the keys array.
    /// </param>
    public static void Sort(this Array array, Array items)
    {
        Array.Sort(array, items);
    }

    /// <summary>
    /// Sorts a range of elements in a one-dimensional array using the default comparer.
    /// </summary>
    /// <param name="array">The one-dimensional array to sort.</param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    public static void Sort(this Array array, int index, int length)
    {
        Array.Sort(array, index, length);
    }

    /// <summary>
    /// Sorts a range of elements in a pair of one-dimensional arrays (keys and corresponding items) based on the keys using the default comparer.
    /// </summary>
    /// <param name="array">The one-dimensional array of keys to sort.</param>
    /// <param name="items">
    /// The one-dimensional array of items that correspond to each of the keys. This array is sorted in parallel with the keys array.
    /// </param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    public static void Sort(this Array array, Array items, int index, int length)
    {
        Array.Sort(array, items, index, length);
    }

    /// <summary>
    /// Sorts the elements in a one-dimensional array using a custom comparer.
    /// </summary>
    /// <param name="array">The one-dimensional array to sort.</param>
    /// <param name="comparer">
    /// The comparer to use when comparing elements, or <c>null</c> to use the default comparer.
    /// </param>
    public static void Sort(this Array array, IComparer comparer)
    {
        Array.Sort(array, comparer);
    }

    /// <summary>
    /// Sorts a pair of one-dimensional arrays (keys and corresponding items) based on the keys using a custom comparer.
    /// </summary>
    /// <param name="array">The one-dimensional array
