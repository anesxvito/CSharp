| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that query if '@this' is not null.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if not null, false if not.</returns>
    public static bool IsNotNull(this String @this)
    {
        return @this != null;
    }
}