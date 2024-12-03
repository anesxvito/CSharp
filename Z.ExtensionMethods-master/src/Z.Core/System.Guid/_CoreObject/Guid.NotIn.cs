using System;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An extension method for Guid to determine if it is not equal to any of the provided values.
    /// </summary>
    /// <param name="guid">The Guid to be compared.</param>
    /// <param name="values">The list of Guid values to compare with.</param>
    /// <returns>true if the values list does not contain the Guid, otherwise false.</returns>
    public static bool NotIn(this Guid guid, params Guid[] values)
    {
        return !values.Contains(guid);
    }
}
