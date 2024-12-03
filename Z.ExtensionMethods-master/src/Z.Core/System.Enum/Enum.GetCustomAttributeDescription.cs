using System;
using System.ComponentModel;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Retrieves the description from the <see cref="DescriptionAttribute"/> of an enum value.
    /// </summary>
    /// <param name="value">The enum value to get the description for.</param>
    /// <returns>The description string associated with the enum value, or an empty string if no description is found.</returns>
    public static string GetCustomAttributeDescription(this Enum value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var descriptionAttribute = fieldInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                             .FirstOrDefault() as DescriptionAttribute;

        return descriptionAttribute?.Description ?? string.Empty;
    }
}
