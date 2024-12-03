#if NET45_OR_GREATER
using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    /// Creates a zip archive containing the files and directories from the specified directory.
    /// </summary>
    /// <param name="directory">The directory to zip.</param>
    /// <param name="destinationArchiveFileName">The path of the archive to be created.</param>
    public static void CreateZipFile(this DirectoryInfo directory, string destinationArchiveFileName)
    {
        ZipFile.CreateFromDirectory(directory.FullName, destinationArchiveFileName);
    }

    /// <summary>
    /// Creates a zip archive containing the files and directories from the specified directory.
    /// Allows specifying compression level and inclusion of the base directory.
    /// </summary>
    /// <param name="directory">The directory to zip.</param>
    /// <param name="destinationArchiveFileName">The path of the archive to be created.</param>
    /// <param name="compressionLevel">Compression level (speed vs effectiveness).</param>
    /// <param name="includeBaseDirectory">Whether to include the base directory in the archive.</param>
    public static void CreateZipFile(this DirectoryInfo directory, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory)
    {
        ZipFile.CreateFromDirectory(directory.FullName, destinationArchiveFileName, compressionLevel, includeBaseDirectory);
    }

    /// <summary>
    /// Creates a zip archive containing the files and directories from the specified directory.
    /// Allows specifying compression level, character encoding for entry names, and inclusion of the base directory.
    /// </summary>
    /// <param name="directory">The directory to zip.</param>
    /// <param name="destinationArchiveFileName">The path of the archive to be created.</param>
    /// <param name="compressionLevel">Compression level (speed vs effectiveness).</param>
    /// <param name="includeBaseDirectory">Whether to include the base directory in the archive.</param>
    /// <param name="entryNameEncoding">The encoding for entry names in the archive.</param>
    public static void CreateZipFile(this DirectoryInfo directory, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
    {
        ZipFile.CreateFromDirectory(directory.FullName, destinationArchiveFileName, compressionLevel, includeBaseDirectory, entryNameEncoding);
    }

    /// <summary>
    /// Creates a zip archive containing the files and directories from the specified directory.
    /// </summary>
    /// <param name="directory">The directory to zip.</param>
    /// <param name="destinationFile">The file info of the archive to be created.</param>
    public static void CreateZipFile(this DirectoryInfo directory, FileInfo destinationFile)
    {
        directory.CreateZipFile(destinationFile.FullName);
    }

    /// <summary>
    /// Creates a zip archive containing the files and directories from the specified directory.
    /// Allows specifying compression level and inclusion of the base directory.
    /// </summary>
    /// <param name="directory">The directory to zip.</param>
    /// <param name="destinationFile">The file info of the archive to be created.</param>
    /// <param name="compressionLevel">Compression level (speed vs effectiveness).</param>
    /// <param name="includeBaseDirectory">Whether to include the base directory in the archive.</param>
    public static void CreateZipFile(this DirectoryInfo directory, FileInfo destinationFile, CompressionLevel compressionLevel, bool includeBaseDirectory)
    {
        directory.CreateZipFile(destinationFile.FullName, compressionLevel, includeBaseDirectory);
    }

    /// <summary>
    /// Creates a zip archive containing the files and directories from the specified directory.
    /// Allows specifying compression level, character encoding for entry names, and inclusion of the base directory.
    /// </summary>
    /// <param name="directory">The directory to zip.</param>
    /// <param name="destinationFile">The file info of the archive to be created.</param>
    /// <param name="compressionLevel">Compression level (speed vs effectiveness).</param>
    /// <param name="includeBaseDirectory">Whether to include the base directory in the archive.</param>
    /// <param name="entryNameEncoding">The encoding for entry names in the archive.</param>
    public static void CreateZipFile(this DirectoryInfo directory, FileInfo destinationFile, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
    {
        directory.CreateZipFile(destinationFile.FullName, compressionLevel, includeBaseDirectory, entryNameEncoding);
    }
}
#endif
