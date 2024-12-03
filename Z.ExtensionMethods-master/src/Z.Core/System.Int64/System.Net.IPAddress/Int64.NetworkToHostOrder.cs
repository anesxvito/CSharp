using System;
using System.Net;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a 64-bit signed integer from network byte order to host byte order.
    /// </summary>
    /// <param name="network">The 64-bit signed integer to convert, expressed in network byte order.</param>
    /// <returns>A 64-bit signed integer, expressed in host byte order.</returns>
    /// <remarks>
    ///     This method assumes the system is using little-endian architecture. If the system
    ///     uses a big-endian architecture, no conversion is necessary.
    /// </remarks>
    public static Int64 NetworkToHostOrder(this Int64 network)
    {
        // If the system's architecture is little-endian, we need to perform the conversion.
        if (BitConverter.IsLittleEndian)
        {
            byte[] bytes = BitConverter.GetBytes(network);
            Array.Reverse(bytes); // Reverse the byte array to convert from network order (big-endian) to host order (little-endian).
            return BitConverter.ToInt64(bytes, 0);
        }

        // If the system is already big-endian, return the number as-is.
        return network;
    }
}
