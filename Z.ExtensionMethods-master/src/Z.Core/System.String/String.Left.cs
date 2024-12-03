| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that return the left part of the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="length">The length.</param>
    /// <returns>The left part.</returns>
    public static string Left(this string @this, int length)
    {
        return @this.Substring(0, length);
    }
}