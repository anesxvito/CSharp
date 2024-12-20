| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and the
    ///     type of the custom attribute to search for.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <returns>
    ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
    ///     attributes exist.
    /// </returns>
    public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType)
    {
        return Attribute.GetCustomAttributes(element, attributeType);
    }

    /// <summary>
    ///     Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, the type
    ///     of the custom attribute to search for, and an ignored search option.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
    /// <returns>
    ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
    ///     attributes exist.
    /// </returns>
    public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType, Boolean inherit)
    {
        return Attribute.GetCustomAttributes(element, attributeType, inherit);
    }

    /// <summary>
    ///     Retrieves an array of the custom attributes applied to an assembly. A parameter specifies the assembly.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
    /// <returns>
    ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
    ///     exist.
    /// </returns>
    public static Attribute[] GetCustomAttributes(this Assembly element)
    {
        return Attribute.GetCustomAttributes(element);
    }

    /// <summary>
    ///     Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and an
    ///     ignored search option.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
    /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
    /// <returns>
    ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
    ///     exist.
    /// </returns>
    public static Attribute[] GetCustomAttributes(this Assembly element, Boolean inherit)
    {
        return Attribute.GetCustomAttributes(element, inherit);
    }
}