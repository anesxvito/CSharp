using System;

public static partial class Extensions
{
    /// <summary>
    ///     Clears all elements in the specified array by setting them to their default values (zero, false, or null).
    /// </summary>
    /// <param name="this">The array to clear.</param>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="this"/> array is null.</exception>
    public static void ClearAll(this Array @this)
    {
        if (@this == null)
        {
            throw new ArgumentNullException(nameof(@this), "Array cannot be null.");
        }

        Array.Clear(@this, 0, @this.Length);
    }
}
