using System;

public static partial class Extensions
{
    /// <summary>
    ///     Checks if the specified index is within the bounds of the one-dimensional array.
    /// </summary>
    /// <param name="this">The array to check.</param>
    /// <param name="index">The zero-based index to check.</param>
    /// <returns><c>true</c> if the index is within bounds; otherwise, <c>false</c>.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the array is <c>null</c>.</exception>
    public static bool WithinIndex(this Array @this, int index)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this), "Array cannot be null.");

        return index >= 0 && index < @this.Length;
    }

    /// <summary>
    ///     Checks if the specified index is within the bounds of the specified dimension of a multi-dimensional array.
    /// </summary>
    /// <param name="this">The array to check.</param>
    /// <param name="index">The index to check.</param>
    /// <param name="dimension">The dimension to check. Default is 0.</param>
    /// <returns><c>true</c> if the index is within bounds; otherwise, <c>false</c>.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the array is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the specified dimension is invalid.</exception>
    public static bool WithinIndex(this Array @this, int index, int dimension = 0)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this), "Array cannot be null.");

        if (dimension < 0 || dimension >= @this.Rank)
            throw new ArgumentOutOfRangeException(nameof(dimension), "Invalid dimension for the array.");

        return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
    }
}
