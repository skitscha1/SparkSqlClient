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
using Microsoft.Extensions.Primitives;
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


public partial class TOperationHandle : TBase
{
  private double _modifiedRowCount;

  public THandleIdentifier OperationId { get; set; }

  /// <summary>
  /// 
  /// <seealso cref="global::.TOperationType"/>
  /// </summary>
  public TOperationType OperationType { get; set; }

  public bool HasResultSet { get; set; }

  public double ModifiedRowCount
  {
    get
    {
      return _modifiedRowCount;
    }
    set
    {
      __isset.modifiedRowCount = true;
      this._modifiedRowCount = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool modifiedRowCount;
  }

  public TOperationHandle()
  {
  }

  public TOperationHandle(THandleIdentifier operationId, TOperationType operationType, bool hasResultSet) : this()
  {
    this.OperationId = operationId;
    this.OperationType = operationType;
    this.HasResultSet = hasResultSet;
  }

  public TOperationHandle DeepCopy()
  {
    var tmp241 = new TOperationHandle();
    if((OperationId != null))
    {
      tmp241.OperationId = (THandleIdentifier)this.OperationId.DeepCopy();
    }
    tmp241.OperationType = this.OperationType;
    tmp241.HasResultSet = this.HasResultSet;
    if(__isset.modifiedRowCount)
    {
      tmp241.ModifiedRowCount = this.ModifiedRowCount;
    }
    tmp241.__isset.modifiedRowCount = this.__isset.modifiedRowCount;
    return tmp241;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_operationId = false;
      bool isset_operationType = false;
      bool isset_hasResultSet = false;
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
            if (field.Type == TType.Struct)
            {
              OperationId = new THandleIdentifier();
              await OperationId.ReadAsync(iprot, cancellationToken);
              isset_operationId = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.I32)
            {
              OperationType = (TOperationType)await iprot.ReadI32Async(cancellationToken);
              isset_operationType = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.Bool)
            {
              HasResultSet = await iprot.ReadBoolAsync(cancellationToken);
              isset_hasResultSet = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.Double)
            {
              ModifiedRowCount = await iprot.ReadDoubleAsync(cancellationToken);
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
      if (!isset_operationId)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_operationType)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_hasResultSet)
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
      var tmp242 = new TStruct("TOperationHandle");
      await oprot.WriteStructBeginAsync(tmp242, cancellationToken);
      var tmp243 = new TField();
      if((OperationId != null))
      {
        tmp243.Name = "operationId";
        tmp243.Type = TType.Struct;
        tmp243.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp243, cancellationToken);
        await OperationId.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      tmp243.Name = "operationType";
      tmp243.Type = TType.I32;
      tmp243.ID = 2;
      await oprot.WriteFieldBeginAsync(tmp243, cancellationToken);
      await oprot.WriteI32Async((int)OperationType, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      tmp243.Name = "hasResultSet";
      tmp243.Type = TType.Bool;
      tmp243.ID = 3;
      await oprot.WriteFieldBeginAsync(tmp243, cancellationToken);
      await oprot.WriteBoolAsync(HasResultSet, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if(__isset.modifiedRowCount)
      {
        tmp243.Name = "modifiedRowCount";
        tmp243.Type = TType.Double;
        tmp243.ID = 4;
        await oprot.WriteFieldBeginAsync(tmp243, cancellationToken);
        await oprot.WriteDoubleAsync(ModifiedRowCount, cancellationToken);
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
    if (!(that is TOperationHandle other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return global::System.Object.Equals(OperationId, other.OperationId)
      && global::System.Object.Equals(OperationType, other.OperationType)
      && global::System.Object.Equals(HasResultSet, other.HasResultSet)
      && ((__isset.modifiedRowCount == other.__isset.modifiedRowCount) && ((!__isset.modifiedRowCount) || (global::System.Object.Equals(ModifiedRowCount, other.ModifiedRowCount))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((OperationId != null))
      {
        hashcode = (hashcode * 397) + OperationId.GetHashCode();
      }
      hashcode = (hashcode * 397) + OperationType.GetHashCode();
      hashcode = (hashcode * 397) + HasResultSet.GetHashCode();
      if(__isset.modifiedRowCount)
      {
        hashcode = (hashcode * 397) + ModifiedRowCount.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var sb = new StringBuilder("TOperationHandle(");
    if((OperationId != null))
    {
      sb.Append(", OperationId: ");
      sb.Append(OperationId);
    }
    sb.Append(", OperationType: ");
    sb.Append(OperationType);
    sb.Append(", HasResultSet: ");
    sb.Append(HasResultSet);
    if(__isset.modifiedRowCount)
    {
      sb.Append(", ModifiedRowCount: ");
      sb.Append(ModifiedRowCount);
    }
    sb.Append(')');
    return sb.ToString();
  }
}

