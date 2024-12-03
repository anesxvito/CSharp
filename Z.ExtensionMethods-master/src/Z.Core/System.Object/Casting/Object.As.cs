public static partial class Extensions
{
    /// <summary>
    ///     Converts an object to the specified type using an explicit cast.
    /// </summary>
    /// <typeparam name="T">The target type to which the object will be cast.</typeparam>
    /// <param name="this">The object to be cast to the specified type.</param>
    /// <returns>The object cast to the specified type <typeparamref name="T"/>.</returns>
    /// <exception cref="InvalidCastException">
    ///     Thrown if the object cannot be cast to the specified type.
    /// </exception>
    /// <remarks>
    ///     This method provides a convenient way to cast an object to a specific type 
    ///     using extension syntax. It is equivalent to directly using a cast operation 
    ///     but provides more fluent syntax within the extension method style.
    /// </remarks>
    public static T As<T>(this object @this)
    {
        return (T)@this;
    }
}
