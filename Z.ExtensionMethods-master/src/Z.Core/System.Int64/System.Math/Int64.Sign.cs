using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns a value indicating the sign of a 64-bit signed integer.
    /// </summary>
    /// <param name="value">A signed 64-bit integer.</param>
    /// <returns>
    ///     A number that indicates the sign of <paramref name="value"/>, as shown in the following table:
    ///     <list type="table">
    ///         <item>
    ///             <term>-1</term>
    ///             <description>If the value is less than zero.</description>
    ///         </item>
    ///         <item>
    ///             <term>0</term>
    ///             <description>If the value is equal to zero.</description>
    ///         </item>
    ///         <item>
    ///             <term>1</term>
    ///             <description>If the value is greater than zero.</description>
    ///         </item>
    ///     </list>
    /// </returns>
    public static int Sign(this long value)
    {
        return Math.Sign(value);
    }
}
