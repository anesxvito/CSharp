using System;

public static partial class Extensions
{
    /// <summary>
    /// Checks if the value is inclusively between the specified minimum and maximum values.
    /// </summary>
    /// <param name="this">The value to compare.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <returns>true if the value is between the minValue and maxValue (inclusive), otherwise false.</returns>
    public static bool InRange(this decimal @this, decimal minValue, decimal maxValue)
    {
        return @this >= minValue && @this <= maxValue;
    }
}
