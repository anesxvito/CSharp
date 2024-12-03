using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that calculates the age based on the given date.
    /// </summary>
    /// <param name="this">The date of birth.</param>
    /// <returns>The age as an integer.</returns>
    public static int Age(this DateTime @this)
    {
        // Get today's date
        var today = DateTime.Today;

        // Calculate the age
        int age = today.Year - @this.Year;

        // Adjust age if the birthday hasn't occurred yet this year
        if (today < @this.AddYears(age))
        {
            age--;
        }

        return age;
    }
}
