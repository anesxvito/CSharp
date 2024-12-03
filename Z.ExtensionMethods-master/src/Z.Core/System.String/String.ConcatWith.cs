| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that concatenate with.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>A string.</returns>
    public static string ConcatWith(this string @this, params string[] values)
    {
        return string.Concat(@this, string.Concat(values));
    }
}