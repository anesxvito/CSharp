using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    /// Compresses the given string into a GZip-compressed byte array using the default encoding.
    /// </summary>
    /// <param name="text">The string to compress.</param>
    /// <returns>A GZip-compressed byte array representing the string.</returns>
    public static byte[] CompressGZip(this string text)
    {
        return text.CompressGZip(Encoding.Default);
    }

    /// <summary>
    /// Compresses the given string into a GZip-compressed byte array using the specified encoding.
    /// </summary>
    /// <param name="text">The string to compress.</param>
    /// <param name="encoding">The encoding to use for converting the string to bytes.</param>
    /// <returns>A GZip-compressed byte array representing the string.</returns>
    public static byte[] CompressGZip(this string text, Encoding encoding)
    {
        byte[] stringBytes = encoding.GetBytes(text);

        using var memoryStream = new MemoryStream();
        using var zipStream = new GZipStream(memoryStream, CompressionMode.Compress);

        zipStream.Write(stringBytes, 0, stringBytes.Length);
        zipStream.Close(); // Ensure all data is flushed to the MemoryStream
        return memoryStream.ToArray();
    }
}
