#if NET45_OR_GREATER
using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    /// Extracts all the files in the specified zip archive to a directory on the file system.
    /// </summary>
    /// <param name="zipFile">The zip archive to extract.</param>
    /// <param name="destinationDirectoryName">The path to the directory where files will be extracted.</param>
    public static void ExtractZipFileToDirectory(this FileInfo zipFile, string destinationDirectoryName)
    {
        ZipFile.ExtractToDirectory(zipFile.FullName, destinationDirectoryName);
    }

    /// <summary>
    /// Extracts all the files in the specified zip archive to a directory on the file system,
    /// using the specified character encoding for entry names.
    /// </summary>
    /// <param name="zipFile">The zip archive to extract.</param>
    /// <param name="destinationDirectoryName">The path to the directory where files will be extracted.</param>
    /// <param name="entryNameEncoding">
    /// The encoding to use for entry names. Use this when interoperability with tools
    /// that do not support UTF-8 is required.
    /// </param>
    public static void ExtractZipFileToDirectory(this FileInfo zipFile, string destinationDirectoryName, Encoding entryNameEncoding)
    {
        ZipFile.ExtractToDirectory(zipFile.FullName, destinationDirectoryName, entryNameEncoding);
    }

    /// <summary>
    /// Extracts all the files in the specified zip archive to a directory on the file system.
    /// </summary>
    /// <param name="zipFile">The zip archive to extract.</param>
    /// <param name="destinationDirectory">The destination directory where files will be extracted.</param>
    public static void ExtractZipFileToDirectory(this FileInfo zipFile, DirectoryInfo destinationDirectory)
    {
        ZipFile.ExtractToDirectory(zipFile.FullName, destinationDirectory.FullName);
    }

    /// <summary>
    /// Extracts all the files in the specified zip archive to a directory on the file system,
    /// using the specified character encoding for entry names.
    /// </summary>
    /// <param name="zipFile">The zip archive to extract.</param>
    /// <param name="destinationDirectory">The destination directory where files will be extracted.</param>
    /// <param name="entryNameEncoding">
    /// The encoding to use for entry names. Use this when interoperability with tools
    /// that do not support UTF-8 is required.
    /// </param>
    public static void ExtractZipFileToDirectory(this FileInfo zipFile, DirectoryInfo destinationDirectory, Encoding entryNameEncoding)
    {
        ZipFile.ExtractToDirectory(zipFile.FullName, destinationDirectory.FullName, entryNameEncoding);
    }
}
#endif
