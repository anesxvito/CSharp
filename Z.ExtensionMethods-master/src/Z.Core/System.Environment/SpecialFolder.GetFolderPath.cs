using System;

public static partial class Extensions
{
    /// <summary>
    ///     An extension method for <see cref="Environment.SpecialFolder"/> that gets the folder path.
    /// </summary>
    /// <param name="folder">The special folder to retrieve the path for.</param>
    /// <returns>The folder path as a string.</returns>
    public static string GetFolderPath(this Environment.SpecialFolder folder)
    {
        return Environment.GetFolderPath(folder);
    }

    /// <summary>
    ///     An extension method for <see cref="Environment.SpecialFolder"/> that gets the folder path with an option.
    /// </summary>
    /// <param name="folder">The special folder to retrieve the path for.</param>
    /// <param name="option">The option that controls the folder path retrieval.</param>
    /// <returns>The folder path as a string.</returns>
    public static string GetFolderPath(this Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
    {
        return Environment.GetFolderPath(folder, option);
    }
}
