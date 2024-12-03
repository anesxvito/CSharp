public static partial class Extensions
{
    /// <summary>
    ///     A byte[] extension method that resizes the byte[].
    /// </summary>
    /// <param name="array">The byte array to act on.</param>
    /// <param name="newSize">The new size for the byte array.</param>
    /// <returns>A resized byte array.</returns>
    public static byte[] Resize(this byte[] array, int newSize)
    {
        Array.Resize(ref array, newSize);
        return array;
    }
}
