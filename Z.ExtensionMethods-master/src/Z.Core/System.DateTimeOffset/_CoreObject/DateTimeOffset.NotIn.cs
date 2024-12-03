using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTimeOffset extension method that checks if the object is not equal to any of the provided values.
    /// </summary>
    /// <param name="this">The DateTimeOffset to be compared.</param>
    /// <param name="values">The list of values to compare with the DateTimeOffset.</param>
    /// <returns>true if the values list doesn't contain the DateTimeOffset, otherwise false.</returns>
    public static bool NotIn(this DateTimeOffset @this, params DateTimeOffset[] values)
    {
        return Array.IndexOf(values, @this) == -1;
    }
}
