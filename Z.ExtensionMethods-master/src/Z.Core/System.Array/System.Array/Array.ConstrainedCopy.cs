using System;

public static partial class Extensions
{
    /// <summary>
    /// Copies a range of elements from a source array, starting at the specified index, to a destination array, 
    /// starting at the specified destination index. Ensures all changes are undone if the copy does not succeed completely.
    /// </summary>
    /// <param name="sourceArray">The array containing the data to copy.</param>
    /// <param name="sourceIndex">The zero-based index in the source array at which copying begins.</param>
    /// <param name="destinationArray">The array that receives the data.</param>
    /// <param name="destinationIndex">The zero-based index in the destination array at which storing begins.</param>
    /// <param name="length">The number of elements to copy.</param>
    public static void ConstrainedCopy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
    {
        Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
    }
}
