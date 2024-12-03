using System;

public static partial class Extensions
{
    /// <summary>
    ///     A short (Int16) extension method that checks if the value is exclusively between the minValue and maxValue.
    /// </summary>
    /// <param name="value">The value to check.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <returns>true if the value is exclusively between the minValue and maxValue, otherwise false.</returns>
    public static bool Between(this Int16 value, Int16 minValue, Int16 maxValue)
    {
        return value > minValue && value < maxValue;
    }
}
