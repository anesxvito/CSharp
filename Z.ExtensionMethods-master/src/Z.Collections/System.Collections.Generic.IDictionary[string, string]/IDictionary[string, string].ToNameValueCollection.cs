using System.Collections.Generic;
using System.Collections.Specialized;

public static partial class Extensions
{
    /// <summary>
    /// Converts the dictionary to a <see cref="NameValueCollection"/>.
    /// </summary>
    /// <param name="dictionary">The dictionary to convert.</param>
    /// <returns>A <see cref="NameValueCollection"/> representation of the dictionary, or null if the dictionary is null.</returns>
    public static NameValueCollection ToNameValueCollection(this IDictionary<string, string> dictionary)
    {
        if (dictionary == null)
        {
            return null;
        }

        var nameValueCollection = new NameValueCollection();
        foreach (var item in dictionary)
        {
            nameValueCollection.Add(item.Key, item.Value);
        }
        return nameValueCollection;
    }
}
