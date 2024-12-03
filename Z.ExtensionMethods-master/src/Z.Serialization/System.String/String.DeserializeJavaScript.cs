| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():



using System.Web.Script.Serialization;
#endif

public static partial class Extensions
{

    /// <summary>
    ///     A string extension method that deserialize a string binary as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The desrialize binary as &lt;T&gt;</returns>
    public static T DeserializeJavaScript<T>(this string @this)
    {
        var serializer = new JavaScriptSerializer();
        return serializer.Deserialize<T>(@this);
    }
#endif
}