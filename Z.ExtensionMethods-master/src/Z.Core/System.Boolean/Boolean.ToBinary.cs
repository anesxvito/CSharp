using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a boolean value to its binary representation as a byte.
    ///     <para>Returns 1 for true, and 0 for false.</para>
    /// </summary>
    /// <param name="this">The boolean value to convert.</param>
    /// <returns>A byte representing the binary value (1 for true, 0 for false).</returns>
    public static byte ToBinary(this bool @this)
    {
        return Convert.ToByte(@this);
    }
}
