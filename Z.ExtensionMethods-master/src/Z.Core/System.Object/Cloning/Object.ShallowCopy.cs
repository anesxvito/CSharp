using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     Creates a shallow copy of the current object. 
    ///     A shallow copy means that the new object will have the same values for reference type fields as the original.
    ///     The reference types will still point to the same objects, but value types will be copied.
    /// </summary>
    /// <typeparam name="T">Generic type parameter of the object being cloned.</typeparam>
    /// <param name="this">The object to act on.</param>
    /// <returns>A shallow copy of the object.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the object does not support shallow copying.</exception>
    public static T ShallowCopy<T>(this T @this)
    {
        if (@this == null)
            throw new ArgumentNullException(nameof(@this), "Cannot perform shallow copy on a null object.");

        // Get the 'MemberwiseClone' method from the object's type
        MethodInfo method = @this.GetType().GetMethod("MemberwiseClone", BindingFlags.NonPublic | BindingFlags.Instance);

        if (method == null)
            throw new InvalidOperationException($"The object of type {typeof(T)} does not support shallow copying.");

        try
        {
            // Invoke 'MemberwiseClone' to create a shallow copy
            return (T)method.Invoke(@this, null);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("An error occurred while performing a shallow copy.", ex);
        }
    }
}
