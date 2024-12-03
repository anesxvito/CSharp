using System;
using System.Text.Json;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that makes a deep copy of '@this' object using JSON serialization.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The copied object of type T.</returns>
    public static T DeepClone<T>(this T @this)
    {
        try
        {
            // Serialize the object to a JSON string
            var json = JsonSerializer.Serialize(@this);

            // Deserialize the JSON string back to a new object
            return JsonSerializer.Deserialize<T>(json);
        }
        catch (Exception ex)
        {
            // Handle errors gracefully and log if necessary
            throw new InvalidOperationException("Error occurred while performing deep clone.", ex);
        }
    }
}
