| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts this object to an u short or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUShortOrDefault(this object @this)
    {
        try
        {
            return Convert.ToUInt16(@this);
        }
        catch (Exception)
        {
            return default(ushort);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an u short or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUShortOrDefault(this object @this, ushort defaultValue)
    {
        try
        {
            return Convert.ToUInt16(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an u short or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUShortOrDefault(this object @this, ushort defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValue;
        }

        try
        {
            return Convert.ToUInt16(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an u short or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUShortOrDefault(this object @this, Func<ushort> defaultValueFactory)
    {
        try
        {
            return Convert.ToUInt16(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an u short or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUShortOrDefault(this object @this, Func<ushort> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValueFactory();
        }

        try
        {
            return Convert.ToUInt16(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}