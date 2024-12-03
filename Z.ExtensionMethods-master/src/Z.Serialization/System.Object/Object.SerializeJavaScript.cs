| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():



using System.Web.Script.Serialization;
#endif

public static partial class Extensions
{

    /// <summary>
    ///     A T extension method that serialize java script.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string SerializeJavaScript<T>(this T @this)
    {
        var serializer = new JavaScriptSerializer();
        return serializer.Serialize(@this);
    }
#endif
}