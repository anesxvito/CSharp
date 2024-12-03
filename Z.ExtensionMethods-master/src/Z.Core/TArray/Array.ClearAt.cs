| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     A T[] extension method that clears at.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The arrayToClear to act on.</param>
    /// <param name="at">at.</param>
    public static void ClearAt<T>(this T[] @this, int at)
    {
        Array.Clear(@this, at, 1);
    }
}