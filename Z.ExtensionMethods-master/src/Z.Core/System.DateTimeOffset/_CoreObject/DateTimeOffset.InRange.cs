using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTimeOffset extension method to check if the value is between inclusively the minValue and maxValue.
    /// </summary>
    /// <param name="this">The DateTimeOffset to act on.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <returns>true if the value is between inclusively the minValue and maxValue, otherwise false.</returns>
    public static bool InRange(this DateTimeOffset @this, DateTimeOffset minValue, DateTimeOffset maxValue)
    {
        return @this >= minValue && @this <= maxValue;
    }
}
