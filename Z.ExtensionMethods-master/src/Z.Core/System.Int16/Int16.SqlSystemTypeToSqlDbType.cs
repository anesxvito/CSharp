using System;
using System.Data;

public static class Extensions
{
    public static SqlDbType SqlSystemTypeToSqlDbType(this short @this)
    {
        switch (@this)
        {
            case 34: // "image"
                return SqlDbType.Image;

            case 35: // "text"
                return SqlDbType.Text;

            case 36: // "uniqueidentifier"
                return SqlDbType.UniqueIdentifier;

            case 40: // "date"
                return SqlDbType.Date;

            case 41: // "time"
                return SqlDbType.Time;

            case 42: // "datetime2"
                return SqlDbType.DateTime2;

            case 43: // "datetimeoffset"
                return SqlDbType.DateTimeOffset;

            case 48: // "tinyint"
                return SqlDbType.TinyInt;

            case 52: // "smallint"
                return SqlDbType.SmallInt;

            case 56: // "int"
                return SqlDbType.Int;

            case 58: // "smalldatetime"
                return SqlDbType.SmallDateTime;

            case 59: // "real"
                return SqlDbType.Real;

            case 60: // "money"
                return SqlDbType.Money;

            case 61: // "datetime"
                return SqlDbType.DateTime;

            case 62: // "float"
                return SqlDbType.Float;

            case 98: // "sql_variant"
                return SqlDbType.Variant;

            case 99: // "ntext"
                return SqlDbType.NText;

            case 104: // "bit"
                return SqlDbType.Bit;

            case 106: // "decimal"
                return SqlDbType.Decimal;

            case 108: // "numeric"
                return SqlDbType.Decimal;

            case 122: // "smallmoney"
                return SqlDbType.SmallMoney;

            case 127: // "bigint"
                return SqlDbType.BigInt;

            case 165: // "varbinary"
                return SqlDbType.VarBinary;

            case 167: // "varchar"
                return SqlDbType.VarChar;

            case 173: // "binary"
                return SqlDbType.Binary;

            case 175: // "char"
                return SqlDbType.Char;

            case 189: // "timestamp"
                return SqlDbType.Timestamp;

            case 231: // "nvarchar", "sysname"
                return SqlDbType.NVarChar;

            case 239: // "nchar"
                return SqlDbType.NChar;

            case 240: // "hierarchyid", "geometry", "geography"
                return SqlDbType.Udt;

            case 241: // "xml"
                return SqlDbType.Xml;

            default:
                throw new Exception($"Unsupported Type: {@this}. Please let us know about this type and we will support it: sales@zzzprojects.com");
        }
    }
}
