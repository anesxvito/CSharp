using System;

public static class Extensions
{
    /// <summary>
    ///     An Int32 extension method that queries if '@this' is prime.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if prime, false if not.</returns>
    public static bool IsPrime(this int @this)
    {
        if (@this == 1 || @this == 2)
        {
            return true;
        }

        if (@this % 2 == 0)
        {
            return false;
        }

        var sqrt = (int) Math.Sqrt(@this);
        for (int t = 3; t <= sqrt; t += 2)
        {
            if (@this % t == 0)
            {
                return false;
            }
        }

        return true;
    }
}
