| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that newline 2 line break.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string Nl2Br(this string @this)
    {
        return @this.Replace("\r\n", "<br />").Replace("\n", "<br />");
    }
}