| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts the @this to a double.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a double.</returns>
    public static double ToDouble(this object @this)
    {
        return Convert.ToDouble(@this);
    }
}