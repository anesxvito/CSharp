public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that queries if '@this' is a valid boolean.
    /// </summary>
    /// <param name="this">The object to check.</param>
    /// <returns>True if the object can be parsed as a boolean, otherwise false.</returns>
    public static bool IsValidBoolean(this object @this)
    {
        if (@this == null)
        {
            return false; // null is not a valid boolean
        }

        bool result;
        return bool.TryParse(@this.ToString(), out result);
    }
}
