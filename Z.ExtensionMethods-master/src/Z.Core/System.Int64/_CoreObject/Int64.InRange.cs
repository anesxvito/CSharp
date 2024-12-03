using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method that checks if the value is between inclusively the minValue and maxValue.
    /// </summary>
    /// <param name="this">The value to act on.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <returns>true if the value is between inclusively the minValue and maxValue, otherwise false.</returns>
    public static bool InRange(this long @this, long minValue, long maxValue)
    {
        return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
    }
}
