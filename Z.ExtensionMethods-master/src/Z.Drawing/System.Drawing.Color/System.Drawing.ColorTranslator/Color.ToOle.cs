| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

using System.Drawing;
#endif

public static partial class Extensions
{

    /// <summary>
    ///     Translates the specified  structure to an OLE color.
    /// </summary>
    /// <param name="c">The  structure to translate.</param>
    /// <returns>The OLE color value.</returns>
    public static Int32 ToOle(this Color c)
    {
        return ColorTranslator.ToOle(c);
    }
#endif
}