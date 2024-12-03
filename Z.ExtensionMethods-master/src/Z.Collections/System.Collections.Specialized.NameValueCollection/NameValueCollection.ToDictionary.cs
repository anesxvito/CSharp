using System.Collections.Generic;
using System.Collections.Specialized;

public static partial class Extensions
{
    /// <summary>
    /// Converts a <see cref="NameValueCollection"/> to a <see cref="IDictionary{TKey, TValue}"/>.
    /// </summary>
    /// <param name="collection">The <see cref="NameValueCollection"/> to convert.</param>
    /// <returns>A <see cref="IDictionary{TKey, TValue}"/> representation of the <see cref="NameValueCollection"/>.</returns>
    public static IDictionary<string, object> ToDictionary(this NameValueCollection collection)
    {
        var dictionary = new Dictionary<string, object>();

        if (collection != null)
        {
            foreach (string key in collection.AllKeys)
            {
                dictionary[key] = collection[key];
            }
        }

        return dictionary;
    }
}
