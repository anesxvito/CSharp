#if NET45_OR_GREATER
using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    /// Opens a zip archive at the specified path in the specified mode.
    /// </summary>
    /// <param name="zipFile">The zip file to open.</param>
    /// <param name="mode">The mode specifying the allowed actions on the archive entries.</param>
    /// <returns>A <see cref="ZipArchive"/> for the opened zip file.</returns>
    public static ZipArchive OpenZipFile(this FileInfo zipFile, ZipArchiveMode mode)
    {
        return ZipFile.Open(zipFile.FullName, mode);
    }

    /// <summary>
    /// Opens a zip archive at the specified path in the specified mode, using the given character encoding for entry names.
    /// </summary>
    /// <param name="zipFile">The zip file to open.</param>
    /// <param name="mode">The mode specifying the allowed actions on the archive entries.</param>
    /// <param name="entryNameEncoding">
    /// The encoding for reading or writing entry names in the archive. Specify this for compatibility 
    /// with tools or libraries that do not support UTF-8 encoding for entry names.
    /// </param>
    /// <returns>A <see cref="ZipArchive"/> for the opened zip file.</returns>
    public static ZipArchive OpenZipFile(this FileInfo zipFile, ZipArchiveMode mode, Encoding entryNameEncoding)
    {
        return ZipFile.Open(zipFile.FullName, mode, entryNameEncoding);
    }
}
#endif
