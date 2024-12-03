using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int16 extension method to determine if the current value is equal to any of the provided values.
    /// </summary>
    /// <param name="value">The value to be compared against the provided values.</param>
    /// <param name="values">A list of values to compare with the current value.</param>
    /// <returns>true if the current value is in the provided list, otherwise false.</returns>
    public static bool In(this Int16 value, params Int16[] values)
    {
        return Array.IndexOf(values, value) != -1;
    }
}
