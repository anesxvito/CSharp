using System.IO;
using System.IO.Compression;

public static partial class Extensions
{
    /// <summary>
    /// Extracts the GZip-compressed file to the current directory with its original name (excluding the .gz extension).
    /// </summary>
    /// <param name="compressedFile">The GZip-compressed file to extract.</param>
    public static void ExtractGZipToDirectory(this FileInfo compressedFile)
    {
        string newFileName = Path.Combine(compressedFile.DirectoryName ?? string.Empty, Path.GetFileNameWithoutExtension(compressedFile.FullName));
        compressedFile.ExtractGZipToDirectory(newFileName);
    }

    /// <summary>
    /// Extracts the GZip-compressed file to the specified destination path.
    /// </summary>
    /// <param name="compressedFile">The GZip-compressed file to extract.</param>
    /// <param name="destinationPath">The destination path for the extracted file.</param>
    public static void ExtractGZipToDirectory(this FileInfo compressedFile, string destinationPath)
    {
        using var originalFileStream = compressedFile.OpenRead();
        using var decompressedFileStream = File.Create(destinationPath);
        using var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress);

        decompressionStream.CopyTo(decompressedFileStream);
    }

    /// <summary>
    /// Extracts the GZip-compressed file to the location specified by the destination <see cref="FileInfo"/>.
    /// </summary>
    /// <param name="compressedFile">The GZip-compressed file to extract.</param>
    /// <param name="destinationFile">The destination file information for the extracted file.</param>
    public static void ExtractGZipToDirectory(this FileInfo compressedFile, FileInfo destinationFile)
    {
        compressedFile.ExtractGZipToDirectory(destinationFile.FullName);
    }
}
