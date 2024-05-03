/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.20.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

public static class TCLIServiceConstants
{
  public static HashSet<TTypeId> PRIMITIVE_TYPES = new HashSet<TTypeId>();
  public static HashSet<TTypeId> COMPLEX_TYPES = new HashSet<TTypeId>();
  public static HashSet<TTypeId> COLLECTION_TYPES = new HashSet<TTypeId>();
  public static Dictionary<TTypeId, string> TYPE_NAMES = new Dictionary<TTypeId, string>();
  public const string CHARACTER_MAXIMUM_LENGTH = "characterMaximumLength";
  public const string PRECISION = "precision";
  public const string SCALE = "scale";
  static TCLIServiceConstants()
  {
    PRIMITIVE_TYPES.Add(TTypeId.BOOLEAN_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.TINYINT_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.SMALLINT_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.INT_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.BIGINT_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.FLOAT_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.DOUBLE_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.STRING_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.TIMESTAMP_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.BINARY_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.DECIMAL_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.NULL_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.DATE_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.VARCHAR_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.CHAR_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.INTERVAL_YEAR_MONTH_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.INTERVAL_DAY_TIME_TYPE);
    PRIMITIVE_TYPES.Add(TTypeId.TIMESTAMPLOCALTZ_TYPE);
    COMPLEX_TYPES.Add(TTypeId.ARRAY_TYPE);
    COMPLEX_TYPES.Add(TTypeId.MAP_TYPE);
    COMPLEX_TYPES.Add(TTypeId.STRUCT_TYPE);
    COMPLEX_TYPES.Add(TTypeId.UNION_TYPE);
    COMPLEX_TYPES.Add(TTypeId.USER_DEFINED_TYPE);
    COLLECTION_TYPES.Add(TTypeId.ARRAY_TYPE);
    COLLECTION_TYPES.Add(TTypeId.MAP_TYPE);
    TYPE_NAMES[TTypeId.ARRAY_TYPE] = "ARRAY";
    TYPE_NAMES[TTypeId.BIGINT_TYPE] = "BIGINT";
    TYPE_NAMES[TTypeId.BINARY_TYPE] = "BINARY";
    TYPE_NAMES[TTypeId.BOOLEAN_TYPE] = "BOOLEAN";
    TYPE_NAMES[TTypeId.CHAR_TYPE] = "CHAR";
    TYPE_NAMES[TTypeId.DATE_TYPE] = "DATE";
    TYPE_NAMES[TTypeId.DECIMAL_TYPE] = "DECIMAL";
    TYPE_NAMES[TTypeId.DOUBLE_TYPE] = "DOUBLE";
    TYPE_NAMES[TTypeId.FLOAT_TYPE] = "FLOAT";
    TYPE_NAMES[TTypeId.INTERVAL_DAY_TIME_TYPE] = "INTERVAL_DAY_TIME";
    TYPE_NAMES[TTypeId.INTERVAL_YEAR_MONTH_TYPE] = "INTERVAL_YEAR_MONTH";
    TYPE_NAMES[TTypeId.INT_TYPE] = "INT";
    TYPE_NAMES[TTypeId.MAP_TYPE] = "MAP";
    TYPE_NAMES[TTypeId.NULL_TYPE] = "NULL";
    TYPE_NAMES[TTypeId.SMALLINT_TYPE] = "SMALLINT";
    TYPE_NAMES[TTypeId.STRING_TYPE] = "STRING";
    TYPE_NAMES[TTypeId.STRUCT_TYPE] = "STRUCT";
    TYPE_NAMES[TTypeId.TIMESTAMPLOCALTZ_TYPE] = "TIMESTAMP WITH LOCAL TIME ZONE";
    TYPE_NAMES[TTypeId.TIMESTAMP_TYPE] = "TIMESTAMP";
    TYPE_NAMES[TTypeId.TINYINT_TYPE] = "TINYINT";
    TYPE_NAMES[TTypeId.UNION_TYPE] = "UNIONTYPE";
    TYPE_NAMES[TTypeId.VARCHAR_TYPE] = "VARCHAR";
  }
}
