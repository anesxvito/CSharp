| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that query if '@this' is empty.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if empty, false if not.</returns>
    public static bool IsEmpty(this string @this)
    {
        return @this == "";
    }
}