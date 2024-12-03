using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the current value is not equal to any of the provided values.
    /// </summary>
    /// <param name="this">The value to be compared.</param>
    /// <param name="values">The list of values to compare with.</param>
    /// <returns>
    ///     <c>true</c> if the value is not found in the list of provided values; otherwise, <c>false</c>.
    /// </returns>
    public static bool NotIn(this double @this, params double[] values)
    {
        return Array.IndexOf(values, @this) == -1;
    }
}
