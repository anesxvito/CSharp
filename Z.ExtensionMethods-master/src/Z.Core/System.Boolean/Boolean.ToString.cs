public static partial class Extensions
{
    /// <summary>
    ///     Converts the boolean value to a string based on the provided true/false values.
    /// </summary>
    /// <param name="this">The boolean value to act on.</param>
    /// <param name="trueValue">The value to return if the boolean is true.</param>
    /// <param name="falseValue">The value to return if the boolean is false.</param>
    /// <returns>A string representing the boolean value with the respective true/false string.</returns>
    public static string ToString(this bool @this, string trueValue, string falseValue)
    {
        return @this ? trueValue : falseValue;
    }
}
