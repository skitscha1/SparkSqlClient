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


public partial class TStructTypeEntry : TBase
{

  public Dictionary<string, int> NameToTypePtr { get; set; }

  public TStructTypeEntry()
  {
  }

  public TStructTypeEntry(Dictionary<string, int> nameToTypePtr) : this()
  {
    this.NameToTypePtr = nameToTypePtr;
  }

  public TStructTypeEntry DeepCopy()
  {
    var tmp30 = new TStructTypeEntry();
    if((NameToTypePtr != null))
    {
      tmp30.NameToTypePtr = this.NameToTypePtr.DeepCopy();
    }
    return tmp30;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_nameToTypePtr = false;
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
            if (field.Type == TType.Map)
            {
              {
                var _map31 = await iprot.ReadMapBeginAsync(cancellationToken);
                NameToTypePtr = new Dictionary<string, int>(_map31.Count);
                for(int _i32 = 0; _i32 < _map31.Count; ++_i32)
                {
                  string _key33;
                  int _val34;
                  _key33 = await iprot.ReadStringAsync(cancellationToken);
                  _val34 = await iprot.ReadI32Async(cancellationToken);
                  NameToTypePtr[_key33] = _val34;
                }
                await iprot.ReadMapEndAsync(cancellationToken);
              }
              isset_nameToTypePtr = true;
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
      if (!isset_nameToTypePtr)
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
      var tmp35 = new TStruct("TStructTypeEntry");
      await oprot.WriteStructBeginAsync(tmp35, cancellationToken);
      var tmp36 = new TField();
      if((NameToTypePtr != null))
      {
        tmp36.Name = "nameToTypePtr";
        tmp36.Type = TType.Map;
        tmp36.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp36, cancellationToken);
        await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.I32, NameToTypePtr.Count), cancellationToken);
        foreach (string _iter37 in NameToTypePtr.Keys)
        {
          await oprot.WriteStringAsync(_iter37, cancellationToken);
          await oprot.WriteI32Async(NameToTypePtr[_iter37], cancellationToken);
        }
        await oprot.WriteMapEndAsync(cancellationToken);
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
    if (!(that is TStructTypeEntry other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return TCollections.Equals(NameToTypePtr, other.NameToTypePtr);
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((NameToTypePtr != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(NameToTypePtr);
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var sb = new StringBuilder("TStructTypeEntry(");
    if((NameToTypePtr != null))
    {
      sb.Append(", NameToTypePtr: ");
      sb.Append(NameToTypePtr);
    }
    sb.Append(')');
    return sb.ToString();
  }
}

