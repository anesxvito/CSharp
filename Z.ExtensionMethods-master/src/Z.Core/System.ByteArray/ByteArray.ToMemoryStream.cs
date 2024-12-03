using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a byte array to a MemoryStream.
    /// </summary>
    /// <param name="data">The byte array to convert.</param>
    /// <returns>A MemoryStream containing the byte array data.</returns>
    public static MemoryStream ToMemoryStream(this byte[] data)
    {
        return new MemoryStream(data);
    }
}
