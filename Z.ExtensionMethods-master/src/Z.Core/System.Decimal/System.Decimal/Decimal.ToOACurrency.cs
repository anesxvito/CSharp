using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified <see cref="Decimal"/> value to the equivalent OLE Automation Currency value, which
    ///     is contained in a 64-bit signed integer.
    /// </summary>
    /// <param name="value">The <see cref="Decimal"/> number to convert to OLE Automation Currency.</param>
    /// <returns>A 64-bit signed integer containing the OLE Automation equivalent of the <paramref name="value"/>.</returns>
    public static long ToOACurrency(this decimal value)
    {
        return Decimal.ToOACurrency(value);
    }
}
