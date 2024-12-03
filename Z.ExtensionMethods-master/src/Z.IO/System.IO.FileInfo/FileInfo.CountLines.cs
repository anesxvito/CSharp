| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>Gets the total number of lines in a file. </summary>
    /// <param name="this">The file to perform the count on.</param>
    /// <returns>The total number of lines in a file. </returns>
    public static int CountLines(this FileInfo @this)
    {
        return File.ReadAllLines(@this.FullName).Length;
    }

    /// <summary>Gets the total number of lines in a file that satisfy the condition in the predicate function.</summary>
    /// <param name="this">The file to perform the count on.</param>
    /// <param name="predicate">A function to test each line for a condition.</param>
    /// <returns>The total number of lines in a file that satisfy the condition in the predicate function.</returns>
    public static int CountLines(this FileInfo @this, Func<string, bool> predicate)
    {
        return File.ReadAllLines(@this.FullName).Count(predicate);
    }
}