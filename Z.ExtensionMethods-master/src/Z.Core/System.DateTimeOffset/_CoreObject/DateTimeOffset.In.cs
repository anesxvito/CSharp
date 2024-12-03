using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTimeOffset extension method to determine whether the object is equal to any of the provided values.
    /// </summary>
    /// <param name="this">The object to be compared.</param>
    /// <param name="values">The value list to compare with the object.</param>
    /// <returns>true if the values list contains the object, else false.</returns>
    public static bool In(this DateTimeOffset @this, params DateTimeOffset[] values)
    {
        return Array.IndexOf(values, @this) >= 0;
    }
}
