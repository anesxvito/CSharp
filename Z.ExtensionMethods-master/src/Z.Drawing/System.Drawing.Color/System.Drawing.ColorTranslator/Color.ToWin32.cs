| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

using System.Drawing;
#endif

public static partial class Extensions
{

    /// <summary>
    ///     Translates the specified  structure to a Windows color.
    /// </summary>
    /// <param name="c">The  structure to translate.</param>
    /// <returns>The Windows color value.</returns>
    public static Int32 ToWin32(this Color c)
    {
        return ColorTranslator.ToWin32(c);
    }
#endif
}