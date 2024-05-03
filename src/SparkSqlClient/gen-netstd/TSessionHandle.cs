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


public partial class TSessionHandle : TBase
{

  public THandleIdentifier SessionId { get; set; }

  public TSessionHandle()
  {
  }

  public TSessionHandle(THandleIdentifier sessionId) : this()
  {
    this.SessionId = sessionId;
  }

  public TSessionHandle DeepCopy()
  {
    var tmp236 = new TSessionHandle()
    if((SessionId != null))
    {
      tmp236.SessionId = (THandleIdentifier)this.SessionId.DeepCopy();
    }
    return tmp236;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_sessionId = false;
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
              SessionId = new THandleIdentifier();
              await SessionId.ReadAsync(iprot, cancellationToken);
              isset_sessionId = true;
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
      if (!isset_sessionId)
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
      var tmp237 = new TStruct("TSessionHandle");
      await oprot.WriteStructBeginAsync(tmp237, cancellationToken);
      var tmp238 = new TField();
      if((SessionId != null))
      {
        tmp238.Name = "sessionId";
        tmp238.Type = TType.Struct;
        tmp238.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp238, cancellationToken);
        await SessionId.WriteAsync(oprot, cancellationToken);
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
    if (!(that is TSessionHandle other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return global::System.Object.Equals(SessionId, other.SessionId);
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((SessionId != null))
      {
        hashcode = (hashcode * 397) + SessionId.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp239 = new StringBuilder("TSessionHandle(");
    if((SessionId != null))
    {
      tmp239.Append(", SessionId: ");
      SessionId.ToString(tmp239);
    }
    tmp239.Append(')');
    return tmp239.ToString();
  }
}

