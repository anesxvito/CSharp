using System;

public static partial class Extensions
{
    /// <summary>
    ///     Checks if the current value is exclusively between the specified minimum and maximum values.
    /// </summary>
    /// <param name="this">The value to compare.</param>
    /// <param name="minValue">The minimum boundary value.</param>
    /// <param name="maxValue">The maximum boundary value.</param>
    /// <returns>
    ///     <c>true</c> if the value is strictly between the <paramref name="minValue"/> and <paramref name="maxValue"/>, 
    ///     otherwise <c>false</c>.
    /// </returns>
    public static bool Between(this double @this, double minValue, double maxValue)
    {
        return minValue < @this && @this < maxValue;
    }
}
