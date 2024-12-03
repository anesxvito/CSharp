using System;

public static partial class Extensions
{
    /// <summary>
    ///     Deserializes a 64-bit binary value and recreates the original DateTime object.
    /// </summary>
    /// <param name="dateData">
    ///     A 64-bit signed integer that represents the serialized form of a DateTime object.
    /// </param>
    /// <returns>A DateTime object that is equivalent to the one serialized by the ToBinary method.</returns>
    public static DateTime FromBinary(this long dateData)
    {
        return DateTime.FromBinary(dateData);
    }
}
