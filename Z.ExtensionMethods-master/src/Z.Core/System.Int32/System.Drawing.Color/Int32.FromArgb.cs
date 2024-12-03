using System;
using System.Drawing;

public static partial class Extensions
{
    /// <summary>
    ///     Creates a Color structure from a 32-bit ARGB value.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <returns>The Color structure that this method creates.</returns>
    public static Color FromArgb(this int argb)
    {
        return Color.FromArgb(argb);
    }

    /// <summary>
    ///     Creates a Color structure from the four ARGB components (alpha, red, green, and blue) values. 
    ///     Although this method allows a 32-bit value to be passed for each component, the value of each component is lied to 8 bits.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <param name="red">The red component. Valid values are 0 through 255.</param>
    /// <param name="green">The green component. Valid values are 0 through 255.</param>
    /// <param name="blue">The blue component. Valid values are 0 through 255.</param>
    /// <returns>The Color structure that this method creates.</returns>
    public static Color FromArgb(this int argb, int red, int green, int blue)
    {
        return Color.FromArgb(argb, red, green, blue);
    }

    /// <summary>
    ///     Creates a Color structure from the specified Color structure, but with the new specified alpha value. 
    ///     Although this method allows a 32-bit value to be passed for the alpha value, the value is lied to 8 bits.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <param name="baseColor">The Color from which to create the new Color.</param>
    /// <returns>The Color structure that this method creates.</returns>
    public static Color FromArgb(this int argb, Color baseColor)
    {
        return Color.FromArgb(argb, baseColor);
    }

    /// <summary>
    ///     Creates a Color structure from the specified 8-bit color values (red, green, and blue). 
    ///     The alpha value is implicitly 255 (fully opaque). 
    ///     Although this method allows a 32-bit value to be passed for each color component, the value of each component is lied to 8 bits.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <param name="green">The green component value for the new Color. Valid values are 0 through 255.</param>
    /// <param name="blue">The blue component value for the new Color. Valid values are 0 through 255.</param>
    /// <returns>The Color structure that this method creates.</returns>
    public static Color FromArgb(this int argb, int red, int green, int blue)
    {
        return Color.FromArgb(argb, red, green, blue);
    }
}
