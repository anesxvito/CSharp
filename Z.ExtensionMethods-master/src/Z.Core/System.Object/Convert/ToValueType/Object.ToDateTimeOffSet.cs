| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts the @this to a date time off set.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DateTimeOffset.</returns>
    public static DateTimeOffset ToDateTimeOffSet(this object @this)
    {
        return new DateTimeOffset(Convert.ToDateTime(@this), TimeSpan.Zero);
    }
}