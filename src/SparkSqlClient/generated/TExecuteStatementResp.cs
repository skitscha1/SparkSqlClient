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


public partial class TExecuteStatementResp : TBase
{
  private TOperationHandle _operationHandle;

  public TStatus Status { get; set; }

  public TOperationHandle OperationHandle
  {
    get
    {
      return _operationHandle;
    }
    set
    {
      __isset.operationHandle = true;
      this._operationHandle = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool operationHandle;
  }

  public TExecuteStatementResp()
  {
  }

  public TExecuteStatementResp(TStatus @status) : this()
  {
    this.Status = @status;
  }

  public TExecuteStatementResp DeepCopy()
  {
    var tmp316 = new TExecuteStatementResp();
    if((Status != null))
    {
      tmp316.Status = (TStatus)this.Status.DeepCopy();
    }
    if((OperationHandle != null) && __isset.operationHandle)
    {
      tmp316.OperationHandle = (TOperationHandle)this.OperationHandle.DeepCopy();
    }
    tmp316.__isset.operationHandle = this.__isset.operationHandle;
    return tmp316;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_status = false;
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
              Status = new TStatus();
              await Status.ReadAsync(iprot, cancellationToken);
              isset_status = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.Struct)
            {
              OperationHandle = new TOperationHandle();
              await OperationHandle.ReadAsync(iprot, cancellationToken);
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
      if (!isset_status)
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
      var tmp317 = new TStruct("TExecuteStatementResp");
      await oprot.WriteStructBeginAsync(tmp317, cancellationToken);
      var tmp318 = new TField();
      if((Status != null))
      {
        tmp318.Name = "status";
        tmp318.Type = TType.Struct;
        tmp318.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp318, cancellationToken);
        await Status.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((OperationHandle != null) && __isset.operationHandle)
      {
        tmp318.Name = "operationHandle";
        tmp318.Type = TType.Struct;
        tmp318.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp318, cancellationToken);
        await OperationHandle.WriteAsync(oprot, cancellationToken);
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
    if (!(that is TExecuteStatementResp other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return global::System.Object.Equals(Status, other.Status)
      && ((__isset.operationHandle == other.__isset.operationHandle) && ((!__isset.operationHandle) || (global::System.Object.Equals(OperationHandle, other.OperationHandle))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((Status != null))
      {
        hashcode = (hashcode * 397) + Status.GetHashCode();
      }
      if((OperationHandle != null) && __isset.operationHandle)
      {
        hashcode = (hashcode * 397) + OperationHandle.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var sb = new StringBuilder("TExecuteStatementResp(");
    if((Status != null))
    {
      sb.Append(", Status: ");
      sb.Append(Status);
    }
    if((OperationHandle != null) && __isset.operationHandle)
    {
      sb.Append(", OperationHandle: ");
      sb.Append(OperationHandle);
    }
    sb.Append(')');
    return sb.ToString();
  }
}

