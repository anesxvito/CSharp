using System;

public static partial class Extensions
{
    /// <summary>
    ///     A Guid extension method that checks if the specified Guid is empty.
    /// </summary>
    /// <param name="guid">The Guid to check.</param>
    /// <returns>true if the Guid is empty, false otherwise.</returns>
    public static bool IsEmpty(this Guid guid)
    {
        return guid == Guid.Empty;
    }
}
