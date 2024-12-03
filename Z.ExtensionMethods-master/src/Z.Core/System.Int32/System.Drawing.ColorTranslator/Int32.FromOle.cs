using System;
using System.Drawing;

public static partial class Extensions
{
    /// <summary>
    ///     Translates an OLE color value to a GDI+ Color structure.
    /// </summary>
    /// <param name="oleColor">The OLE color to translate.</param>
    /// <returns>The Color structure that represents the translated OLE color.</returns>
    public static Color FromOle(this int oleColor)
    {
        return ColorTranslator.FromOle(oleColor);
    }
}
