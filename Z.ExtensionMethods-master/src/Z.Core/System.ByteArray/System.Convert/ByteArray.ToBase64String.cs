using System;

public static partial class Extensions
{
    /// <summary>
    /// Converts a byte array to its equivalent base64 string representation.
    /// </summary>
    /// <param name="inArray">An array of 8-bit unsigned integers.</param>
    /// <param name="offset">The starting index of the subset to convert.</param>
    /// <param name="length">The number of elements to convert.</param>
    /// <param name="options">The formatting options for the base64 string (optional).</param>
    /// <returns>The base64-encoded string representation of the byte array subset.</returns>
    public static string ToBase64String(this byte[] inArray, int offset = 0, int length = -1, Base64FormattingOptions options = Base64FormattingOptions.None)
    {
        // Use the full length of the array if the length is not specified.
        if (length == -1)
        {
            length = inArray.Length - offset;
        }

        // Return the appropriate base64 string based on the options.
        return Convert.ToBase64String(inArray, offset, length, options);
    }
}
