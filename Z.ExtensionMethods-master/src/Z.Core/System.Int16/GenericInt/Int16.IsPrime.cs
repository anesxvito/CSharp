using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int16 extension method that checks if the value is a prime number.
    /// </summary>
    /// <param name="value">The value to act on.</param>
    /// <returns>true if the value is prime, false otherwise.</returns>
    public static bool IsPrime(this Int16 value)
    {
        // Handle edge cases
        if (value < 2)
        {
            return false;
        }

        if (value == 2)
        {
            return true;
        }

        // Eliminate even numbers greater than 2
        if (value % 2 == 0)
        {
            return false;
        }

        // Check for factors from 3 to sqrt(value)
        var li = (int) Math.Sqrt(value);
        for (int i = 3; i <= li; i += 2)
        {
            if (value % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
