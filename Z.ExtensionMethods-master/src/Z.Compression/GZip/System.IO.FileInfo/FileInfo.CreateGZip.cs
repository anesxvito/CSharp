using System.IO;
using System.IO.Compression;

public static partial class Extensions
{
    /// <summary>
    /// Compresses the file into a GZip file at the same location with a ".gz" extension.
    /// </summary>
    /// <param name="file">The file to compress.</param>
    public static void CreateGZip(this FileInfo file)
    {
        file.CreateGZip(file.FullName + ".gz");
    }

    /// <summary>
    /// Compresses the file into a GZip file at the specified destination path.
    /// </summary>
    /// <param name="file">The file to compress.</param>
    /// <param name="destinationPath">The destination path for the compressed file.</param>
    public static void CreateGZip(this FileInfo file, string destinationPath)
    {
        using var originalFileStream = file.OpenRead();
        using var compressedFileStream = File.Create(destinationPath);
        using var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress);

        originalFileStream.CopyTo(compressionStream);
    }

    /// <summary>
    /// Compresses the file into a GZip file at the location specified by the destination <see cref="FileInfo"/>.
    /// </summary>
    /// <param name="file">The file to compress.</param>
    /// <param name="destinationFile">The destination file information for the compressed file.</param>
    public static void CreateGZip(this FileInfo file, FileInfo destinationFile)
    {
        file.CreateGZip(destinationFile.FullName);
    }
}
