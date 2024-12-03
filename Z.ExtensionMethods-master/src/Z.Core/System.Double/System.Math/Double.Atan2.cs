using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the angle whose tangent is the quotient of two specified numbers.
    /// </summary>
    /// <param name="y">The y coordinate of a point.</param>
    /// <param name="x">The x coordinate of a point.</param>
    /// <returns>
    ///     An angle, in radians, such that <c>tan(θ) = y / x</c>, where (x, y) is a point in the Cartesian plane.
    ///     The returned angle will be in the range of <c>−π to π</c>:
    ///     - For points in the first quadrant, <c>0 < θ < π/2</c>.
    ///     - For points in the second quadrant, <c>π/2 < θ < π</c>.
    ///     - For points in the third quadrant, <c>−π < θ < −π/2</c>.
    ///     - For points in the fourth quadrant, <c>−π/2 < θ < 0</c>.
    ///     - Special cases:
    ///       - If y is 0 and x is not negative, θ = 0.
    ///       - If y is 0 and x is negative, θ = π.
    ///       - If y is positive and x is 0, θ = π/2.
    ///       - If y is negative and x is 0, θ = −π/2.
    ///       - If both x and y are 0, the method returns NaN.
    /// </returns>
    public static double Atan2(this double y, double x)
    {
        return Math.Atan2(y, x);
    }
}
