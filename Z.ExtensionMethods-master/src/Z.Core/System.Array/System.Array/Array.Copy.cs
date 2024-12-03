using System;

public static partial class Extensions
{
    /// <summary>
    /// Copies a range of elements from the source array, starting at the first element, into the destination array, 
    /// starting at the first element. The length is specified as a 32-bit integer.
    /// </summary>
    /// <param name="sourceArray">The array that contains the data to copy.</param>
    /// <param name="destinationArray">The array that receives the data.</param>
    /// <param name="length">The number of elements to copy.</param>
    public static void Copy(this Array sourceArray, Array destinationArray, int length)
    {
        Array.Copy(sourceArray, destinationArray, length);
    }

    /// <summary>
    /// Copies a range of elements from the source array, starting at the specified index, into the destination array, 
    /// starting at the specified destination index. The length and indexes are specified as 32-bit integers.
    /// </summary>
    /// <param name="sourceArray">The array that contains the data to copy.</param>
    /// <param name="sourceIndex">The zero-based index in the source array at which copying begins.</param>
    /// <param name="destinationArray">The array that receives the data.</param>
    /// <param name="destinationIndex">The zero-based index in the destination array at which storing begins.</param>
    /// <param name="length">The number of elements to copy.</param>
    public static void Copy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
    {
        Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
    }

    /// <summary>
    /// Copies a range of elements from the source array, starting at the first element, into the destination array, 
    /// starting at the first element. The length is specified as a 64-bit integer.
    /// </summary>
    /// <param name="sourceArray">The array that contains the data to copy.</param>
    /// <param name="destinationArray">The array that receives the data.</param>
    /// <param name="length">The number of elements to copy.</param>
    public static void Copy(this Array sourceArray, Array destinationArray, long length)
    {
        Array.Copy(sourceArray, destinationArray, length);
    }

    /// <summary>
    /// Copies a range of elements from the source array, starting at the specified index, into the destination array, 
    /// starting at the specified destination index. The length and indexes are specified as 64-bit integers.
    /// </summary>
    /// <param name="sourceArray">The array that contains the data to copy.</param>
    /// <param name="sourceIndex">The zero-based index in the source array at which copying begins.</param>
    /// <param name="destinationArray">The array that receives the data.</param>
    /// <param name="destinationIndex">The zero-based index in the destination array at which storing begins.</param>
    /// <param name="length">The number of elements to copy.</param>
    public static void Copy(this Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
    {
        Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
    }
}
