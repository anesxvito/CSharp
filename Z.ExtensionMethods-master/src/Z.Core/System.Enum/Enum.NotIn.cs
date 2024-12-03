using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the current enum value is not equal to any of the provided values.
    /// </summary>
    /// <param name="value">The enum value to be compared.</param>
    /// <param name="values">An array of enum values to compare with the current value.</param>
    /// <returns>true if the current value is not contained in the provided values array; otherwise, false.</returns>
    public static bool NotIn(this Enum value, params Enum[] values)
    {
        // Ensure the values array is not null and contains elements
        if (values == null || values.Length == 0)
        {
            return true;  // If no values are provided, the current value is considered "not in" the list
        }

        // Check if the current enum value is not contained in the values array
        return Array.IndexOf(values, value) == -1;
    }
}
