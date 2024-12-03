using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Determines whether the object is equal to any of the provided values.
    /// </summary>
    /// <param name="this">The object to be compared.</param>
    /// <param name="values">The value list to compare with the object.</param>
    /// <returns>true if the values list contains the object, else false.</returns>
    public static bool In(this decimal @this, params decimal[] values)
    {
        var valueSet = new HashSet<decimal>(values);
        return valueSet.Contains(@this);
    }
}
