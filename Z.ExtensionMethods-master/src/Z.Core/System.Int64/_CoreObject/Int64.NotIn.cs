using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method to determine whether the object is not equal to any of the provided values.
    /// </summary>
    /// <param name="this">The object to be compared.</param>
    /// <param name="values">The value list to compare with the object.</param>
    /// <returns>true if the values list doesn't contain the object, else false.</returns>
    public static bool NotIn(this long @this, params long[] values)
    {
        return Array.IndexOf(values, @this) == -1;
    }
}
