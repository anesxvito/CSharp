#if NET45_OR_GREATER
using System.IO;
using System.IO.Compression;

public static partial class Extensions
{
    /// <summary>
    /// Opens a zip archive for reading.
    /// </summary>
    /// <param name="zipFile">The zip file to open, specified as a <see cref="FileInfo"/>.</param>
    /// <returns>A <see cref="ZipArchive"/> representing the opened zip file in read mode.</returns>
    public static ZipArchive OpenReadZipFile(this FileInfo zipFile)
    {
        return ZipFile.OpenRead(zipFile.FullName);
    }
}
#endif
