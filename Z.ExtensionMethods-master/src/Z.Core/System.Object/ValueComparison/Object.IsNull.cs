| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that query if '@this' is null.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if null, false if not.</returns>
    public static bool IsNull<T>(this T @this) where T : class
    {
        return @this == null;
    }
}