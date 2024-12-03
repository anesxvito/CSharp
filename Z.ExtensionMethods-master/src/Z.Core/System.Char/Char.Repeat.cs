public static partial class Extensions
{
    /// <summary>
    /// Repeats a character a specified number of times.
    /// </summary>
    /// <param name="this">The character to repeat.</param>
    /// <param name="repeatCount">The number of times to repeat the character.</param>
    /// <returns>A string consisting of the repeated character.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when repeatCount is less than zero.</exception>
    public static string Repeat(this char @this, int repeatCount)
    {
        if (repeatCount < 0)
            throw new ArgumentOutOfRangeException(nameof(repeatCount), "Repeat count must be greater than or equal to zero.");

        return new string(@this, repeatCount);
    }
}
