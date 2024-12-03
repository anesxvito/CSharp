using System;

public static partial class Extensions
{
    /// <summary>
    ///     An EventHandler extension method that raises the event.
    /// </summary>
    /// <param name="handler">The EventHandler to raise.</param>
    /// <param name="sender">Source of the event.</param>
    public static void RaiseEvent(this EventHandler handler, object sender)
    {
        handler?.Invoke(sender, EventArgs.Empty);
    }

    /// <summary>
    ///     An EventHandler extension method that raises the event with custom EventArgs.
    /// </summary>
    /// <param name="handler">The EventHandler to raise.</param>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    public static void Raise(this EventHandler handler, object sender, EventArgs e)
    {
        handler?.Invoke(sender, e);
    }

    /// <summary>
    ///     An EventHandler&lt;TEventArgs&gt; extension method that raises the event with default event arguments.
    /// </summary>
    /// <typeparam name="TEventArgs">Type of the event arguments.</typeparam>
    /// <param name="handler">The EventHandler&lt;TEventArgs&gt; to raise.</param>
    /// <param name="sender">Source of the event.</param>
    public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> handler, object sender) where TEventArgs : EventArgs
    {
        handler?.Invoke(sender, Activator.CreateInstance<TEventArgs>());
    }

    /// <summary>
    ///     An EventHandler&lt;TEventArgs&gt; extension method that raises the event with provided event arguments.
    /// </summary>
    /// <typeparam name="TEventArgs">Type of the event arguments.</typeparam>
    /// <param name="handler">The EventHandler&lt;TEventArgs&gt; to raise.</param>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information to send to registered event handlers.</param>
    public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> handler, object sender, TEventArgs e) where TEventArgs : EventArgs
    {
        handler?.Invoke(sender, e);
    }
}
