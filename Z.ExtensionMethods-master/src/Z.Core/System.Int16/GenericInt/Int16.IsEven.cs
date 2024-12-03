using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Int16 value is even.
    /// </summary>
    /// <param name="value">The Int16 value to check.</param>
    /// <returns>true if the value is even; otherwise, false.</returns>
    public static bool IsEven(this Int16 value)
    {
        return value % 2 == 0;
    }
}
