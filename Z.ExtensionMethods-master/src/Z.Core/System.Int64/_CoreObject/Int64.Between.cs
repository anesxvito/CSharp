using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method that checks if the value is between (exclusive) the minValue and maxValue.
    /// </summary>
    /// <param name="this">The value to act on.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <returns>true if the value is between the minValue and maxValue, otherwise false.</returns>
    public static bool Between(this long @this, long minValue, long maxValue)
    {
        return minValue.CompareTo(@this) < 0 && @this.CompareTo(maxValue) < 0;
    }
}
