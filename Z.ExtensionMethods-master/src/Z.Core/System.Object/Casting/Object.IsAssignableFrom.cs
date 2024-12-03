using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the type of the current object can be assigned from the specified type.
    /// </summary>
    /// <typeparam name="T">The target type to check against.</typeparam>
    /// <param name="this">The object to check.</param>
    /// <returns>true if the object's type is assignable from the specified type; otherwise, false.</returns>
    public static bool CanAssignTo<T>(this object @this)
    {
        return @this.GetType().IsAssignableFrom(typeof(T));
    }

    /// <summary>
    ///     Determines whether the type of the current object can be assigned from the specified target type.
    /// </summary>
    /// <param name="this">The object to check.</param>
    /// <param name="targetType">The target type to check against.</param>
    /// <returns>true if the object's type is assignable from the target type; otherwise, false.</returns>
    public static bool CanAssignTo(this object @this, Type targetType)
    {
        return @this.GetType().IsAssignableFrom(targetType);
    }
}
