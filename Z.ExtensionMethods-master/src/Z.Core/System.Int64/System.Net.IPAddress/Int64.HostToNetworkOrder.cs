using System;
using System.Net;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a 64-bit signed integer from host byte order to network byte order.
    /// </summary>
    /// <param name="host">The 64-bit signed integer to convert, expressed in host byte order.</param>
    /// <returns>A 64-bit signed integer, expressed in network byte order.</returns>
    /// <remarks>
    ///     <para>
    ///         This method internally calls IPAddress.HostToNetworkOrder for 32-bit integers
    ///         and manually handles the conversion for 64-bit integers.
    ///     </para>
    ///     <para>
    ///         This method assumes the system is using a little-endian architecture. If the system
    ///         uses a big-endian architecture, no conversion is necessary.
    ///     </para>
    /// </remarks>
    public static Int64 HostToNetworkOrder(this Int64 host)
    {
        // If the system's architecture is little-endian, we need to perform the conversion.
        if (BitConverter.IsLittleEndian)
        {
            byte[] bytes = BitConverter.GetBytes(host);
            Array.Reverse(bytes); // Reverse the byte array to convert to network order (big-endian).
            return BitConverter.ToInt64(bytes, 0);
        }

        // If the system is already big-endian, return the number as-is.
        return host;
    }
}
