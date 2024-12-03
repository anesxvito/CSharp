using System;

public static partial class Extensions
{
    /// <summary>
    ///     Attempts to convert an object to the specified type. If the conversion fails, returns the default value of the specified type.
    /// </summary>
    /// <typeparam name="T">The target type to convert the object to.</typeparam>
    /// <param name="this">The object to convert.</param>
    /// <returns>The object as the specified type, or the default value of the type if the conversion fails.</returns>
    public static T AsOrDefault<T>(this object @this)
    {
        try
        {
            return (T)@this;
        }
        catch (InvalidCastException)
        {
            return default;
        }
    }

    /// <summary>
    ///     Attempts to convert an object to the specified type. If the conversion fails, returns the provided default value.
    /// </summary>
    /// <typeparam name="T">The target type to convert the object to.</typeparam>
    /// <param name="this">The object to convert.</param>
    /// <param name="defaultValue">The value to return if the conversion fails.</param>
    /// <returns>The object as the specified type, or the provided default value if the conversion fails.</returns>
    public static T AsOrDefault<T>(this object @this, T defaultValue)
    {
        try
        {
            return (T)@this;
        }
        catch (InvalidCastException)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     Attempts to convert an object to the specified
