using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the current value is equal to any of the specified values.
    /// </summary>
    /// <param name="this">The value to be compared.</param>
    /// <param name="values">An array of values to compare with.</param>
    /// <returns>
    ///     <c>true</c> if the current value is equal to any of the values in the <paramref name="values"/> array;
    ///     otherwise, <c>false</c>.
    /// </returns>
    public static bool In(this double @this, params double[] values)
    {
        return Array.IndexOf(values, @this) != -1;
    }
}
