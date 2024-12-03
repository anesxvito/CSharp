using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method that checks if the number is prime.
    /// </summary>
    /// <param name="this">The number to check.</param>
    /// <returns>true if the number is prime, false otherwise.</returns>
    public static bool IsPrime(this long @this)
    {
        // Handle special cases
        if (@this == 1)
        {
            return false;
        }

        if (@this == 2)
        {
            return true; // 2 is the only even prime number
        }

        // Eliminate even numbers quickly
        if (@this % 2 == 0)
        {
            return false;
        }

        // Check for factors up to the square root of the number
        var sqrt = (long)Math.Sqrt(@this);
        for (long t = 3; t <= sqrt; t += 2)  // Check only odd numbers
        {
            if (@this % t == 0)
            {
                return false;
            }
        }

        return true;
    }
}
