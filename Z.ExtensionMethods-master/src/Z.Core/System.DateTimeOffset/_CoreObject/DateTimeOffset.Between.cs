using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTimeOffset extension method that checks if the value is exclusively between the minValue and maxValue.
    /// </summary>
    /// <param name="this">The DateTimeOffset to act on.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <returns>true if the value is between minValue and maxValue, otherwise false.</returns>
    public static bool Between(this DateTimeOffset @this, DateTimeOffset minValue, DateTimeOffset maxValue)
    {
        return minValue.CompareTo(@this) < 0 && @this.CompareTo(maxValue) < 0;
    }
}
