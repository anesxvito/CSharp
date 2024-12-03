using System;

public static partial class Extensions
{
    /// <summary>
    /// Converts a subset of an 8-bit unsigned integer array to a base-64 encoded character array.
    /// </summary>
    /// <param name="inArray">The input array of 8-bit unsigned integers.</param>
    /// <param name="offsetIn">The position within the input array.</param>
    /// <param name="length">The number of elements in the input array to convert.</param>
    /// <param name="outArray">The output array of base64-encoded characters.</param>
    /// <param name="offsetOut">The position within the output array.</param>
    /// <param name="options">Formatting options for base64 encoding.</param>
    /// <returns>The number of characters written to the output array.</returns>
    public static int ToBase64CharArray(this byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options = Base64FormattingOptions.None)
    {
        return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options);
    }
}
