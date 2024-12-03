using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the current value is within the specified range (inclusive of both min and max values).
    /// </summary>
    /// <param name="this">The value to be checked.</param>
    /// <param name="minValue">The inclusive minimum value of the range.</param>
    /// <param name="maxValue">The inclusive maximum value of the range.</param>
    /// <returns>
    ///     <c>true</c> if the current value is greater than or equal to <paramref name="minValue"/> and less than or equal to <paramref name="maxValue"/>;
    ///     otherwise, <c>false</c>.
    /// </returns>
    public static bool InRange(this double @this, double minValue, double maxValue)
    {
        return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
    }
}
