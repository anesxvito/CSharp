using System;
using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a SQL system type byte to the corresponding SqlDbType.
    /// </summary>
    /// <param name="this">The byte value representing the SQL system type ID.</param>
    /// <returns>The corresponding SqlDbType.</returns>
    /// <exception cref="Exception">Thrown when an unsupported byte value is provided.</exception>
    public static SqlDbType SqlSystemTypeToSqlDbType(this byte @this)
    {
        switch (@this)
        {
            case 34:  // "image" -> SqlDbType.Image
                return SqlDbType.Image;
            case 35:  // "text" -> SqlDbType.Text
                return SqlDbType.Text;
            case 36:  // "uniqueidentifier" -> SqlDbType.UniqueIdentifier
                return SqlDbType.UniqueIdentifier;
            case 40:  // "date" -> SqlDbType.Date
                return SqlDbType.Date;
            case 41:  // "time" -> SqlDbType.Time
                return SqlDbType.Time;
            case 42:  // "datetime2" -> SqlDbType.DateTime2
                return SqlDbType.DateTime2;
            case 43:  // "datetimeoffset" -> SqlDbType.DateTimeOffset
                return SqlDbType.DateTimeOffset;
            case 48:  // "tinyint" -> SqlDbType.TinyInt
                return SqlDbType.TinyInt;
            case 52:  // "smallint" -> SqlDbType.SmallInt
                return SqlDbType.SmallInt;
            case 56:  // "int" -> SqlDbType.Int
                return SqlDbType.Int;
            case 58:  // "smalldatetime" -> SqlDbType.SmallDateTime
                return SqlDbType.SmallDateTime;
            case 59:  // "real" -> SqlDbType.Real
                return SqlDbType.Real;
            case 60:  // "money" -> SqlDbType.Money
                return SqlDbType.Money;
            case 61:  // "datetime" -> SqlDbType.DateTime
                return SqlDbType.DateTime;
            case 62:  // "float" -> SqlDbType.Float
                return SqlDbType.Float;
            case 98:  // "sql_variant" -> SqlDbType.Variant
                return SqlDbType.Variant;
            case 99:  // "ntext" -> SqlDbType.NText
                return SqlDbType.NText;
            case 104: // "bit" -> SqlDbType.Bit
                return SqlDbType.Bit;
            case 106: // "decimal" -> SqlDbType.Decimal
                return SqlDbType.Decimal;
            case 108: // "numeric" -> SqlDbType.Decimal
                return SqlDbType.Decimal;
            case 122: // "smallmoney" -> SqlDbType.SmallMoney
                return SqlDbType.SmallMoney;
            case 127: // "bigint" -> SqlDbType.BigInt
                return SqlDbType.BigInt;
            case 165: // "varbinary" -> SqlDbType.VarBinary
                return SqlDbType.VarBinary;
            case 167: // "varchar" -> SqlDbType.VarChar
                return SqlDbType.VarChar;
            case 173: // "binary" -> SqlDbType.Binary
                return SqlDbType.Binary;
            case 175: // "char" -> SqlDbType.Char
                return SqlDbType.Char;
            case 189: // "timestamp" -> SqlDbType.Timestamp
                return SqlDbType.Timestamp;
            case 231: // "nvarchar", "sysname" -> SqlDbType.NVarChar
                return SqlDbType.NVarChar;
            case 239: // "nchar" -> SqlDbType.NChar
                return SqlDbType.NChar;
            case 240: // "hierarchyid", "geometry", "geography" -> SqlDbType.Udt
                return SqlDbType.Udt;
            case 241: // "xml" -> SqlDbType.Xml
                return SqlDbType.Xml;
            default:
                // Improved exception with clearer message for unsupported types
                throw new Exception($"Unsupported SQL System Type byte: {@this}. Please let us know about this type at sales@zzzprojects.com for future support.");
        }
    }
}
