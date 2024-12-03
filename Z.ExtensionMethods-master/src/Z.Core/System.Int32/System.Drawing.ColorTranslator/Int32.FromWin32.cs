using System;
using System.Drawing;

public static partial class Extensions
{
    /// <summary>
    ///     Translates a Windows color value to a GDI+ Color structure.
    /// </summary>
    /// <param name="win32Color">The Windows color to translate.</param>
    /// <returns>The Color structure that represents the translated Windows color.</returns>
    public static Color FromWin32(this int win32Color)
    {
        return ColorTranslator.FromWin32(win32Color);
    }
}
