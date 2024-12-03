using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the largest integer less than or equal to the specified decimal number.
    /// </summary>
    /// <param name="d">A decimal number to evaluate.</param>
    /// <returns>
    ///     The largest integer less than or equal to <paramref name="d"/>. Note that this method returns a 
    ///     <see cref="Decimal"/> instead of an integral type.
    /// </returns>
    public static Decimal Floor(this Decimal d)
    {
        return Math.Floor(d);
    }
}
