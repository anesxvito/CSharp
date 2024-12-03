using System;

public static partial class Extensions
{
    /// <summary>
    ///     A Guid extension method that checks if the specified Guid is not empty.
    /// </summary>
    /// <param name="guid">The Guid to check.</param>
    /// <returns>true if the Guid is not empty, false otherwise.</returns>
    public static bool IsNotEmpty(this Guid guid)
    {
        return guid != Guid.Empty;
    }
}
