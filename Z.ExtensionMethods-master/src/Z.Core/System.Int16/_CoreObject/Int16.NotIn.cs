using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int16 extension method that determines whether the value is not equal to any of the provided values.
    /// </summary>
    /// <param name="value">The value to be compared.</param>
    /// <param name="values">The values to compare with the given value.</param>
    /// <returns>true if the value is not in the list of provided values, otherwise false.</returns>
    public static bool NotIn(this Int16 value, params Int16[] values)
    {
        return Array.IndexOf(values, value) == -1;
    }
}
