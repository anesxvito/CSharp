using System;

public static partial class Extensions
{
    /// <summary>
    ///     Executes the specified <see cref="Action"/> if the boolean value is <c>true</c>.
    /// </summary>
    /// <param name="this">The boolean value to evaluate.</param>
    /// <param name="action">The <see cref="Action"/> to execute if the value is <c>true</c>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="action"/> is <c>null</c>.</exception>
    public static void IfTrue(this bool @this, Action action)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action), "Action cannot be null.");
        }

        if (@this)
        {
            action();
        }
    }
}
