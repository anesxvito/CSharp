using System;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the value is not equal to any of the provided values.
    /// </summary>
    /// <param name="this">The object to be compared.</param>
    /// <param name="values">The list of values to compare with the object.</param>
    /// <returns>true if the object is not contained in the values list; otherwise, false.</returns>
    public static bool NotIn(this decimal @this, params decimal[] values)
    {
        return !values.Contains(@this);
    }
}
