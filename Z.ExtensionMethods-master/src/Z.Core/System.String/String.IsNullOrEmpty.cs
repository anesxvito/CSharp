| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that queries if '@this' is null or is empty.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if '@this' is null or is empty, false if not.</returns>
    public static bool IsNullOrEmpty(this string @this)
    {
        return string.IsNullOrEmpty(@this);
    }
}