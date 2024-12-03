| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;

public static partial class Extensions
{
    /// <summary>A FieldInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetSignature(this FieldInfo @this)
    {
        return @this.Name;
    }
}