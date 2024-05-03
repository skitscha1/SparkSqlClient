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
using Thrift.Protocol;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

public static class TCLIServiceExtensions
{
  public static bool Equals(this Dictionary<string, TTypeQualifierValue> instance, object that)
  {
    if (!(that is Dictionary<string, TTypeQualifierValue> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this Dictionary<string, TTypeQualifierValue> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static Dictionary<string, TTypeQualifierValue> DeepCopy(this Dictionary<string, TTypeQualifierValue> source)
  {
    if (source == null)
      return null;

    var tmp1022 = new Dictionary<string, TTypeQualifierValue>(source.Count);
    foreach (var pair in source)
      tmp1022.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
    return tmp1022;
  }


  public static bool Equals(this Dictionary<string, int> instance, object that)
  {
    if (!(that is Dictionary<string, int> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this Dictionary<string, int> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static Dictionary<string, int> DeepCopy(this Dictionary<string, int> source)
  {
    if (source == null)
      return null;

    var tmp1023 = new Dictionary<string, int>(source.Count);
    foreach (var pair in source)
      tmp1023.Add((pair.Key != null) ? pair.Key : null, pair.Value);
    return tmp1023;
  }


  public static bool Equals(this Dictionary<string, string> instance, object that)
  {
    if (!(that is Dictionary<string, string> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this Dictionary<string, string> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static Dictionary<string, string> DeepCopy(this Dictionary<string, string> source)
  {
    if (source == null)
      return null;

    var tmp1024 = new Dictionary<string, string>(source.Count);
    foreach (var pair in source)
      tmp1024.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value : null);
    return tmp1024;
  }


  public static bool Equals(this List<List<string>> instance, object that)
  {
    if (!(that is List<List<string>> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<List<string>> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<List<string>> DeepCopy(this List<List<string>> source)
  {
    if (source == null)
      return null;

    var tmp1025 = new List<List<string>>(source.Count);
    foreach (var elem in source)
      tmp1025.Add((elem != null) ? elem.DeepCopy() : null);
    return tmp1025;
  }


  public static bool Equals(this List<TColumn> instance, object that)
  {
    if (!(that is List<TColumn> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<TColumn> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<TColumn> DeepCopy(this List<TColumn> source)
  {
    if (source == null)
      return null;

    var tmp1026 = new List<TColumn>(source.Count);
    foreach (var elem in source)
      tmp1026.Add((elem != null) ? elem.DeepCopy() : null);
    return tmp1026;
  }


  public static bool Equals(this List<TColumnDesc> instance, object that)
  {
    if (!(that is List<TColumnDesc> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<TColumnDesc> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<TColumnDesc> DeepCopy(this List<TColumnDesc> source)
  {
    if (source == null)
      return null;

    var tmp1027 = new List<TColumnDesc>(source.Count);
    foreach (var elem in source)
      tmp1027.Add((elem != null) ? elem.DeepCopy() : null);
    return tmp1027;
  }


  public static bool Equals(this List<TColumnValue> instance, object that)
  {
    if (!(that is List<TColumnValue> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<TColumnValue> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<TColumnValue> DeepCopy(this List<TColumnValue> source)
  {
    if (source == null)
      return null;

    var tmp1028 = new List<TColumnValue>(source.Count);
    foreach (var elem in source)
      tmp1028.Add((elem != null) ? elem.DeepCopy() : null);
    return tmp1028;
  }


  public static bool Equals(this List<TRow> instance, object that)
  {
    if (!(that is List<TRow> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<TRow> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<TRow> DeepCopy(this List<TRow> source)
  {
    if (source == null)
      return null;

    var tmp1029 = new List<TRow>(source.Count);
    foreach (var elem in source)
      tmp1029.Add((elem != null) ? elem.DeepCopy() : null);
    return tmp1029;
  }


  public static bool Equals(this List<TTypeEntry> instance, object that)
  {
    if (!(that is List<TTypeEntry> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<TTypeEntry> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<TTypeEntry> DeepCopy(this List<TTypeEntry> source)
  {
    if (source == null)
      return null;

    var tmp1030 = new List<TTypeEntry>(source.Count);
    foreach (var elem in source)
      tmp1030.Add((elem != null) ? elem.DeepCopy() : null);
    return tmp1030;
  }


  public static bool Equals(this List<bool> instance, object that)
  {
    if (!(that is List<bool> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<bool> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<bool> DeepCopy(this List<bool> source)
  {
    if (source == null)
      return null;

    var tmp1031 = new List<bool>(source.Count);
    foreach (var elem in source)
      tmp1031.Add(elem);
    return tmp1031;
  }


  public static bool Equals(this List<byte[]> instance, object that)
  {
    if (!(that is List<byte[]> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<byte[]> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<byte[]> DeepCopy(this List<byte[]> source)
  {
    if (source == null)
      return null;

    var tmp1032 = new List<byte[]>(source.Count);
    foreach (var elem in source)
      tmp1032.Add((elem != null) ? elem.ToArray() : null);
    return tmp1032;
  }


  public static bool Equals(this List<double> instance, object that)
  {
    if (!(that is List<double> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<double> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<double> DeepCopy(this List<double> source)
  {
    if (source == null)
      return null;

    var tmp1033 = new List<double>(source.Count);
    foreach (var elem in source)
      tmp1033.Add(elem);
    return tmp1033;
  }


  public static bool Equals(this List<int> instance, object that)
  {
    if (!(that is List<int> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<int> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<int> DeepCopy(this List<int> source)
  {
    if (source == null)
      return null;

    var tmp1034 = new List<int>(source.Count);
    foreach (var elem in source)
      tmp1034.Add(elem);
    return tmp1034;
  }


  public static bool Equals(this List<long> instance, object that)
  {
    if (!(that is List<long> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<long> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<long> DeepCopy(this List<long> source)
  {
    if (source == null)
      return null;

    var tmp1035 = new List<long>(source.Count);
    foreach (var elem in source)
      tmp1035.Add(elem);
    return tmp1035;
  }


  public static bool Equals(this List<sbyte> instance, object that)
  {
    if (!(that is List<sbyte> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<sbyte> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<sbyte> DeepCopy(this List<sbyte> source)
  {
    if (source == null)
      return null;

    var tmp1036 = new List<sbyte>(source.Count);
    foreach (var elem in source)
      tmp1036.Add(elem);
    return tmp1036;
  }


  public static bool Equals(this List<short> instance, object that)
  {
    if (!(that is List<short> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<short> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<short> DeepCopy(this List<short> source)
  {
    if (source == null)
      return null;

    var tmp1037 = new List<short>(source.Count);
    foreach (var elem in source)
      tmp1037.Add(elem);
    return tmp1037;
  }


  public static bool Equals(this List<string> instance, object that)
  {
    if (!(that is List<string> other)) return false;
    if (ReferenceEquals(instance, other)) return true;

    return TCollections.Equals(instance, other);
  }


  public static int GetHashCode(this List<string> instance)
  {
    return TCollections.GetHashCode(instance);
  }


  public static List<string> DeepCopy(this List<string> source)
  {
    if (source == null)
      return null;

    var tmp1038 = new List<string>(source.Count);
    foreach (var elem in source)
      tmp1038.Add((elem != null) ? elem : null);
    return tmp1038;
  }


}
