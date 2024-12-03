using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    /// Decompresses a GZip-compressed byte array into a string using the default encoding.
    /// </summary>
    /// <param name="compressedData">The GZip-compressed byte array.</param>
    /// <returns>The decompressed string.</returns>
    public static string DecompressGZip(this byte[] compressedData)
    {
        return compressedData.DecompressGZip(Encoding.Default);
    }

    /// <summary>
    /// Decompresses a GZip-compressed byte array into a string using the specified encoding.
    /// </summary>
    /// <param name="compressedData">The GZip-compressed byte array.</param>
    /// <param name="encoding">The encoding to use for the resulting string.</param>
    /// <returns>The decompressed string.</returns>
    public static string DecompressGZip(this byte[] compressedData, Encoding encoding)
    {
        using var memoryStream = new MemoryStream(compressedData);
        using var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
        using var outStream = new MemoryStream();

        zipStream.CopyTo(outStream);
        return encoding.GetString(outStream.ToArray());
    }
}
