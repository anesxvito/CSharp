using System;
using System.Net;

public static partial class Extensions
{
    /// <summary>
    ///     Converts an integer value from host byte order to network byte order.
    /// </summary>
    /// <param name="host">The number to convert, expressed in host byte order.</param>
    /// <returns>An integer value, expressed in network byte order.</returns>
    public static int HostToNetworkOrder(this int host)
    {
        return IPAddress.HostToNetworkOrder(host);
    }
}
