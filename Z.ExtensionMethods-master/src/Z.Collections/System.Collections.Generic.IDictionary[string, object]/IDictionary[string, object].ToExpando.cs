using System.Collections.Generic;
using System.Dynamic;

public static partial class Extensions
{
    /// <summary>
    /// Converts the dictionary to an <see cref="ExpandoObject"/>.
    /// </summary>
    /// <param name="dictionary">The dictionary to convert.</param>
    /// <returns>An <see cref="ExpandoObject"/> representation of the dictionary.</returns>
    public static ExpandoObject ToExpando(this IDictionary<string, object> dictionary)
    {
        var expando = new ExpandoObject();
        var expandoDict = (IDictionary<string, object>)expando;

        foreach (var item in dictionary)
        {
            if (item.Value is IDictionary<string, object> subDictionary)
            {
                expandoDict.Add(item.Key, subDictionary.ToExpando());
            }
            else
            {
                expandoDict.Add(item);
            }
        }

        return expando;
    }
}
