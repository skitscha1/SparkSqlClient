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
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions


public partial class TDoubleColumn : TBase
{

  public List<double> Values { get; set; }

  public byte[] Nulls { get; set; }

  public TDoubleColumn()
  {
  }

  public TDoubleColumn(List<double> @values, byte[] @nulls) : this()
  {
    this.Values = @values;
    this.Nulls = @nulls;
  }

  public TDoubleColumn DeepCopy()
  {
    var tmp177 = new TDoubleColumn();
    if((Values != null))
    {
      tmp177.Values = this.Values.DeepCopy();
    }
    if((Nulls != null))
    {
      tmp177.Nulls = this.Nulls.ToArray();
    }
    return tmp177;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_values = false;
      bool isset_nulls = false;
      TField field;
      await iprot.ReadStructBeginAsync(cancellationToken);
      while (true)
      {
        field = await iprot.ReadFieldBeginAsync(cancellationToken);
        if (field.Type == TType.Stop)
        {
          break;
        }

        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.List)
            {
              {
                var _list178 = await iprot.ReadListBeginAsync(cancellationToken);
                Values = new List<double>(_list178.Count);
                for(int _i179 = 0; _i179 < _list178.Count; ++_i179)
                {
                  double _elem180;
                  _elem180 = await iprot.ReadDoubleAsync(cancellationToken);
                  Values.Add(_elem180);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_values = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.String)
            {
              Nulls = await iprot.ReadBinaryAsync(cancellationToken);
              isset_nulls = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          default: 
            await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            break;
        }

        await iprot.ReadFieldEndAsync(cancellationToken);
      }

      await iprot.ReadStructEndAsync(cancellationToken);
      if (!isset_values)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_nulls)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
  {
    oprot.IncrementRecursionDepth();
    try
    {
      var tmp181 = new TStruct("TDoubleColumn");
      await oprot.WriteStructBeginAsync(tmp181, cancellationToken);
      var tmp182 = new TField();
      if((Values != null))
      {
        tmp182.Name = "values";
        tmp182.Type = TType.List;
        tmp182.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp182, cancellationToken);
        await oprot.WriteListBeginAsync(new TList(TType.Double, Values.Count), cancellationToken);
        foreach (double _iter183 in Values)
        {
          await oprot.WriteDoubleAsync(_iter183, cancellationToken);
        }
        await oprot.WriteListEndAsync(cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((Nulls != null))
      {
        tmp182.Name = "nulls";
        tmp182.Type = TType.String;
        tmp182.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp182, cancellationToken);
        await oprot.WriteBinaryAsync(Nulls, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      await oprot.WriteFieldStopAsync(cancellationToken);
      await oprot.WriteStructEndAsync(cancellationToken);
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override bool Equals(object that)
  {
    if (!(that is TDoubleColumn other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return TCollections.Equals(Values, other.Values)
      && TCollections.Equals(Nulls, other.Nulls);
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((Values != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Values);
      }
      if((Nulls != null))
      {
        hashcode = (hashcode * 397) + Nulls.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var sb = new StringBuilder("TDoubleColumn(");
    if((Values != null))
    {
      sb.Append(", Values: ");
      sb.Append(Values);
    }
    if((Nulls != null))
    {
      sb.Append(", Nulls: ");
      sb.Append(Nulls);
    }
    sb.Append(')');
    return sb.ToString();
  }
}

