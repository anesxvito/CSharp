using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    /// Enumerates from @this to toCharacter.
    /// </summary>
    /// <param name="this">The starting character.</param>
    /// <param name="toCharacter">The target character.</param>
    /// <returns>An enumerator that allows foreach to be used to process characters from @this to toCharacter.</returns>
    /// <exception cref="ArgumentException">Thrown when the characters are not in a valid range.</exception>
    public static IEnumerable<char> To(this char @this, char toCharacter)
    {
        if (@this == toCharacter)
            yield return @this; // If both characters are the same, return the single character.

        bool reverseRequired = @this > toCharacter;

        char first = reverseRequired ? toCharacter : @this;
        char last = reverseRequired ? @this : toCharacter;

        // Check if the characters are within a valid range
        if (first > last)
            throw new ArgumentException("The starting character must be less than or equal to the ending character for ascending ranges.");

        // Iterate over the range, reversing if needed.
        foreach (var ch in Enumerable.Range(first, last - first + 1).Select(charCode => (char)charCode))
        {
            yield return ch;
        }

        // If the range is reversed, we reverse the iteration.
        if (reverseRequired)
        {
            var reversedResult = Enumerable.Range(first, last - first + 1)
                                           .Select(charCode => (char)charCode)
                                           .Reverse();
            foreach (var ch in reversedResult)
            {
                yield return ch;
            }
        }
    }
}
