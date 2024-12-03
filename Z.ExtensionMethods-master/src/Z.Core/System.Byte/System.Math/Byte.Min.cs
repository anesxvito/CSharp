public static partial class Extensions
{
    /// <summary>
    ///     Returns the smaller of two 8-bit unsigned integers.
    /// </summary>
    /// <param name="val1">The first of two 8-bit unsigned integers to compare.</param>
    /// <param name="val2">The second of two 8-bit unsigned integers to compare.</param>
    /// <returns>The smaller of the two values.</returns>
    public static byte Min(this byte val1, byte val2)
    {
        return Math.Min(val1, val2);
    }
}
