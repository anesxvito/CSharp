using System;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An extension method for Guid that checks if the current Guid is equal to any of the provided values.
    /// </summary>
    /// <param name="guid">The Guid to be compared.</param>
    /// <param name="values">The array of Guid values to compare with.</param>
    /// <returns>true if the values list contains the Guid, otherwise false.</returns>
    public static bool In(this Guid guid, params Guid[] values)
    {
        return values.Contains(guid);
    }
}
