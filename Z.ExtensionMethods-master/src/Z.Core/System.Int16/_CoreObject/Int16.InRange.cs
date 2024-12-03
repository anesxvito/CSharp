using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int16 extension method that checks if the value is inclusively between the specified minValue and maxValue.
    /// </summary>
    /// <param name="value">The value to be checked.</param>
    /// <param name="minValue">The minimum value in the range.</param>
    /// <param name="maxValue">The maximum value in the range.</param>
    /// <returns>true if the value is between minValue and maxValue inclusively, otherwise false.</returns>
    public static bool InRange(this Int16 value, Int16 minValue, Int16 maxValue)
    {
        return value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0;
    }
}
