using System.Drawing;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a byte array to an Image.
    /// </summary>
    /// <param name="data">The byte array representing the image data.</param>
    /// <returns>The Image created from the byte array.</returns>
    public static Image ToImage(this byte[] data)
    {
        using (var memoryStream = new MemoryStream(data))
        {
            return Image.FromStream(memoryStream);
        }
    }
}
