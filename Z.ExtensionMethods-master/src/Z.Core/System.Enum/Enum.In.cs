using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the current enum value is equal to any of the provided values.
    /// </summary>
    /// <param name="value">The enum value to be compared.</param>
    /// <param name="values">An array of enum values to compare with the current value.</param>
    /// <returns>true if the current value is contained in the provided values array; otherwise, false.</returns>
    public static bool In(this Enum value, params Enum[] values)
    {
        // Ensure the values array is not null and contains elements
        if (values == null || values.Length == 0)
        {
            return false;
        }

        // Compare the current enum value with each value in the array
        return Array.IndexOf(values, value) >= 0;
    }
}
