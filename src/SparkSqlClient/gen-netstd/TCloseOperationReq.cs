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


public partial class TCloseOperationReq : TBase
{

  public TOperationHandle OperationHandle { get; set; }

  public TCloseOperationReq()
  {
  }

  public TCloseOperationReq(TOperationHandle operationHandle) : this()
  {
    this.OperationHandle = operationHandle;
  }

  public TCloseOperationReq DeepCopy()
  {
    var tmp460 = new TCloseOperationReq()
    if((OperationHandle != null))
    {
      tmp460.OperationHandle = (TOperationHandle)this.OperationHandle.DeepCopy();
    }
    return tmp460;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_operationHandle = false;
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
              OperationHandle = new TOperationHandle();
              await OperationHandle.ReadAsync(iprot, cancellationToken);
              isset_operationHandle = true;
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
      if (!isset_operationHandle)
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
      var tmp461 = new TStruct("TCloseOperationReq");
      await oprot.WriteStructBeginAsync(tmp461, cancellationToken);
      var tmp462 = new TField();
      if((OperationHandle != null))
      {
        tmp462.Name = "operationHandle";
        tmp462.Type = TType.Struct;
        tmp462.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp462, cancellationToken);
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
    if (!(that is TCloseOperationReq other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return global::System.Object.Equals(OperationHandle, other.OperationHandle);
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((OperationHandle != null))
      {
        hashcode = (hashcode * 397) + OperationHandle.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp463 = new StringBuilder("TCloseOperationReq(");
    if((OperationHandle != null))
    {
      tmp463.Append(", OperationHandle: ");
      OperationHandle.ToString(tmp463);
    }
    tmp463.Append(')');
    return tmp463.ToString();
  }
}

