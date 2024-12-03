| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Collections.Generic;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     An IEnumerable&lt;DirectoryInfo&gt; extension method that deletes the given @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void Delete(this IEnumerable<DirectoryInfo> @this)
    {
        foreach (DirectoryInfo t in @this)
        {
            t.Delete();
        }
    }
}