using System.Collections;

public static partial class Extensions
{
    /// <summary>
    /// Converts the dictionary to a <see cref="Hashtable"/>.
    /// </summary>
    /// <param name="dictionary">The dictionary to convert.</param>
    /// <returns>A <see cref="Hashtable"/> containing the same key-value pairs as the original dictionary.</returns>
    public static Hashtable ToHashtable(this IDictionary dictionary)
    {
        return new Hashtable(dictionary);
    }
}
