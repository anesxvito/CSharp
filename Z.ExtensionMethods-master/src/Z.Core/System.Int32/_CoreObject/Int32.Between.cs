using System;

public static class Extensions
{
    /// <summary>
    ///     A T extension method that checks if the value is between (exclusive) the minValue and maxValue.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <returns>true if the value is between the minValue and maxValue, otherwise false.</returns>
    /// ###
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public static bool Between(this int @this, int minValue, int maxValue)
    {
        return minValue.CompareTo(@this) < 0 && @this.CompareTo(maxValue) < 0;
    }
}
