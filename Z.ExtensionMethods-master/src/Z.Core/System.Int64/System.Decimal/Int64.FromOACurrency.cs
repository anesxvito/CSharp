using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified 64-bit signed integer, which represents an OLE Automation Currency value, 
    ///     to its equivalent decimal value.
    /// </summary>
    /// <param name="cy">The OLE Automation Currency value. This is a 64-bit signed integer that represents
    ///     a currency value as the number of 100-nanosecond intervals since midnight, January 1, 1900.</param>
    /// <returns>
    ///     A decimal value that represents the equivalent of the specified OLE Automation Currency value.
    /// </returns>
    public static decimal FromOACurrency(this long cy)
    {
        return Decimal.FromOACurrency(cy);
    }
}
