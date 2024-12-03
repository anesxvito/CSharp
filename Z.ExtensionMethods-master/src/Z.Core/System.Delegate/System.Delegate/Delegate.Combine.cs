using System;

public static partial class Extensions
{
    /// <summary>
    ///     Concatenates the invocation lists of two delegates, creating a new delegate.
    /// </summary>
    /// <param name="a">The delegate whose invocation list comes first.</param>
    /// <param name="b">The delegate whose invocation list comes last.</param>
    /// <returns>
    ///     A new delegate with an invocation list that combines the invocation lists of <paramref name="a"/> and <paramref name="b"/>.
    ///     Returns <c>null</c> if both <paramref name="a"/> and <paramref name="b"/> are <c>null</c>.
    ///     If only one of the delegates is <c>null</c>, the other delegate is returned.
    /// </returns>
    public static Delegate Combine(this Delegate a, Delegate b)
    {
        return Delegate.Combine(a, b);
    }
}
