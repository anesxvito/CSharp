using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a <see cref="double"/> value to a money format by rounding it to two decimal places.
    /// </summary>
    /// <param name="value">The <see cref="double"/> value to convert.</param>
    /// <returns>The <see cref="double"/> value rounded to two decimal places, representing money.</returns>
    public static double ToMoney(this double value)
    {
        return Math.Round(value, 2);
    }
}
