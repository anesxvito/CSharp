using System;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    /// Encodes a byte array into its equivalent string representation using base64 digits, 
    /// which is usable for transmission in a URL (URL-safe base64 encoding).
    /// </summary>
    /// <param name="input">The byte array to encode.</param>
    /// <returns>
    /// The string containing the encoded token if the byte array length is greater than one; 
    /// otherwise, an empty string ("").
    /// </returns>
    public static string UrlTokenEncode(this byte[] input)
    {
        // Return an empty string if the byte array is empty or null
        if (input == null || input.Length == 0)
        {
            return string.Empty;
        }

        // Use HttpServerUtility.UrlTokenEncode for URL-safe base64 encoding
        return HttpServerUtility.UrlTokenEncode(input);
    }
}
