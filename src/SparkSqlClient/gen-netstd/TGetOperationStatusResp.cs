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


public partial class TGetOperationStatusResp : TBase
{
  private TOperationState _operationState;
  private string _sqlState;
  private int _errorCode;
  private string _errorMessage;
  private string _taskStatus;
  private long _operationStarted;
  private long _operationCompleted;
  private bool _hasResultSet;
  private TProgressUpdateResp _progressUpdateResponse;
  private long _numModifiedRows;

  public TStatus Status { get; set; }

  /// <summary>
  /// 
  /// <seealso cref="global::.TOperationState"/>
  /// </summary>
  public TOperationState OperationState
  {
    get
    {
      return _operationState;
    }
    set
    {
      __isset.operationState = true;
      this._operationState = value;
    }
  }

  public string SqlState
  {
    get
    {
      return _sqlState;
    }
    set
    {
      __isset.sqlState = true;
      this._sqlState = value;
    }
  }

  public int ErrorCode
  {
    get
    {
      return _errorCode;
    }
    set
    {
      __isset.errorCode = true;
      this._errorCode = value;
    }
  }

  public string ErrorMessage
  {
    get
    {
      return _errorMessage;
    }
    set
    {
      __isset.errorMessage = true;
      this._errorMessage = value;
    }
  }

  public string TaskStatus
  {
    get
    {
      return _taskStatus;
    }
    set
    {
      __isset.taskStatus = true;
      this._taskStatus = value;
    }
  }

  public long OperationStarted
  {
    get
    {
      return _operationStarted;
    }
    set
    {
      __isset.operationStarted = true;
      this._operationStarted = value;
    }
  }

  public long OperationCompleted
  {
    get
    {
      return _operationCompleted;
    }
    set
    {
      __isset.operationCompleted = true;
      this._operationCompleted = value;
    }
  }

  public bool HasResultSet
  {
    get
    {
      return _hasResultSet;
    }
    set
    {
      __isset.hasResultSet = true;
      this._hasResultSet = value;
    }
  }

  public TProgressUpdateResp ProgressUpdateResponse
  {
    get
    {
      return _progressUpdateResponse;
    }
    set
    {
      __isset.progressUpdateResponse = true;
      this._progressUpdateResponse = value;
    }
  }

  public long NumModifiedRows
  {
    get
    {
      return _numModifiedRows;
    }
    set
    {
      __isset.numModifiedRows = true;
      this._numModifiedRows = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool operationState;
    public bool sqlState;
    public bool errorCode;
    public bool errorMessage;
    public bool taskStatus;
    public bool operationStarted;
    public bool operationCompleted;
    public bool hasResultSet;
    public bool progressUpdateResponse;
    public bool numModifiedRows;
  }

  public TGetOperationStatusResp()
  {
  }

  public TGetOperationStatusResp(TStatus @status) : this()
  {
    this.Status = @status;
  }

  public TGetOperationStatusResp DeepCopy()
  {
    var tmp445 = new TGetOperationStatusResp()
    if((Status != null))
    {
      tmp445.Status = (TStatus)this.Status.DeepCopy();
    }
    if(__isset.operationState)
    {
      tmp445.OperationState = this.OperationState;
    }
    tmp445.__isset.operationState = this.__isset.operationState;
    if((SqlState != null) && __isset.sqlState)
    {
      tmp445.SqlState = this.SqlState;
    }
    tmp445.__isset.sqlState = this.__isset.sqlState;
    if(__isset.errorCode)
    {
      tmp445.ErrorCode = this.ErrorCode;
    }
    tmp445.__isset.errorCode = this.__isset.errorCode;
    if((ErrorMessage != null) && __isset.errorMessage)
    {
      tmp445.ErrorMessage = this.ErrorMessage;
    }
    tmp445.__isset.errorMessage = this.__isset.errorMessage;
    if((TaskStatus != null) && __isset.taskStatus)
    {
      tmp445.TaskStatus = this.TaskStatus;
    }
    tmp445.__isset.taskStatus = this.__isset.taskStatus;
    if(__isset.operationStarted)
    {
      tmp445.OperationStarted = this.OperationStarted;
    }
    tmp445.__isset.operationStarted = this.__isset.operationStarted;
    if(__isset.operationCompleted)
    {
      tmp445.OperationCompleted = this.OperationCompleted;
    }
    tmp445.__isset.operationCompleted = this.__isset.operationCompleted;
    if(__isset.hasResultSet)
    {
      tmp445.HasResultSet = this.HasResultSet;
    }
    tmp445.__isset.hasResultSet = this.__isset.hasResultSet;
    if((ProgressUpdateResponse != null) && __isset.progressUpdateResponse)
    {
      tmp445.ProgressUpdateResponse = (TProgressUpdateResp)this.ProgressUpdateResponse.DeepCopy();
    }
    tmp445.__isset.progressUpdateResponse = this.__isset.progressUpdateResponse;
    if(__isset.numModifiedRows)
    {
      tmp445.NumModifiedRows = this.NumModifiedRows;
    }
    tmp445.__isset.numModifiedRows = this.__isset.numModifiedRows;
    return tmp445;
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
            if (field.Type == TType.I32)
            {
              OperationState = (TOperationState)await iprot.ReadI32Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.String)
            {
              SqlState = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.I32)
            {
              ErrorCode = await iprot.ReadI32Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.String)
            {
              ErrorMessage = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 6:
            if (field.Type == TType.String)
            {
              TaskStatus = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 7:
            if (field.Type == TType.I64)
            {
              OperationStarted = await iprot.ReadI64Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 8:
            if (field.Type == TType.I64)
            {
              OperationCompleted = await iprot.ReadI64Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 9:
            if (field.Type == TType.Bool)
            {
              HasResultSet = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 10:
            if (field.Type == TType.Struct)
            {
              ProgressUpdateResponse = new TProgressUpdateResp();
              await ProgressUpdateResponse.ReadAsync(iprot, cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 11:
            if (field.Type == TType.I64)
            {
              NumModifiedRows = await iprot.ReadI64Async(cancellationToken);
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
      var tmp446 = new TStruct("TGetOperationStatusResp");
      await oprot.WriteStructBeginAsync(tmp446, cancellationToken);
      var tmp447 = new TField();
      if((Status != null))
      {
        tmp447.Name = "status";
        tmp447.Type = TType.Struct;
        tmp447.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await Status.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.operationState)
      {
        tmp447.Name = "operationState";
        tmp447.Type = TType.I32;
        tmp447.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await oprot.WriteI32Async((int)OperationState, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((SqlState != null) && __isset.sqlState)
      {
        tmp447.Name = "sqlState";
        tmp447.Type = TType.String;
        tmp447.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await oprot.WriteStringAsync(SqlState, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.errorCode)
      {
        tmp447.Name = "errorCode";
        tmp447.Type = TType.I32;
        tmp447.ID = 4;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await oprot.WriteI32Async(ErrorCode, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((ErrorMessage != null) && __isset.errorMessage)
      {
        tmp447.Name = "errorMessage";
        tmp447.Type = TType.String;
        tmp447.ID = 5;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await oprot.WriteStringAsync(ErrorMessage, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((TaskStatus != null) && __isset.taskStatus)
      {
        tmp447.Name = "taskStatus";
        tmp447.Type = TType.String;
        tmp447.ID = 6;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await oprot.WriteStringAsync(TaskStatus, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.operationStarted)
      {
        tmp447.Name = "operationStarted";
        tmp447.Type = TType.I64;
        tmp447.ID = 7;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await oprot.WriteI64Async(OperationStarted, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.operationCompleted)
      {
        tmp447.Name = "operationCompleted";
        tmp447.Type = TType.I64;
        tmp447.ID = 8;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await oprot.WriteI64Async(OperationCompleted, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.hasResultSet)
      {
        tmp447.Name = "hasResultSet";
        tmp447.Type = TType.Bool;
        tmp447.ID = 9;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await oprot.WriteBoolAsync(HasResultSet, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((ProgressUpdateResponse != null) && __isset.progressUpdateResponse)
      {
        tmp447.Name = "progressUpdateResponse";
        tmp447.Type = TType.Struct;
        tmp447.ID = 10;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await ProgressUpdateResponse.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if(__isset.numModifiedRows)
      {
        tmp447.Name = "numModifiedRows";
        tmp447.Type = TType.I64;
        tmp447.ID = 11;
        await oprot.WriteFieldBeginAsync(tmp447, cancellationToken);
        await oprot.WriteI64Async(NumModifiedRows, cancellationToken);
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
    if (!(that is TGetOperationStatusResp other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return global::System.Object.Equals(Status, other.Status)
      && ((__isset.operationState == other.__isset.operationState) && ((!__isset.operationState) || (global::System.Object.Equals(OperationState, other.OperationState))))
      && ((__isset.sqlState == other.__isset.sqlState) && ((!__isset.sqlState) || (global::System.Object.Equals(SqlState, other.SqlState))))
      && ((__isset.errorCode == other.__isset.errorCode) && ((!__isset.errorCode) || (global::System.Object.Equals(ErrorCode, other.ErrorCode))))
      && ((__isset.errorMessage == other.__isset.errorMessage) && ((!__isset.errorMessage) || (global::System.Object.Equals(ErrorMessage, other.ErrorMessage))))
      && ((__isset.taskStatus == other.__isset.taskStatus) && ((!__isset.taskStatus) || (global::System.Object.Equals(TaskStatus, other.TaskStatus))))
      && ((__isset.operationStarted == other.__isset.operationStarted) && ((!__isset.operationStarted) || (global::System.Object.Equals(OperationStarted, other.OperationStarted))))
      && ((__isset.operationCompleted == other.__isset.operationCompleted) && ((!__isset.operationCompleted) || (global::System.Object.Equals(OperationCompleted, other.OperationCompleted))))
      && ((__isset.hasResultSet == other.__isset.hasResultSet) && ((!__isset.hasResultSet) || (global::System.Object.Equals(HasResultSet, other.HasResultSet))))
      && ((__isset.progressUpdateResponse == other.__isset.progressUpdateResponse) && ((!__isset.progressUpdateResponse) || (global::System.Object.Equals(ProgressUpdateResponse, other.ProgressUpdateResponse))))
      && ((__isset.numModifiedRows == other.__isset.numModifiedRows) && ((!__isset.numModifiedRows) || (global::System.Object.Equals(NumModifiedRows, other.NumModifiedRows))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((Status != null))
      {
        hashcode = (hashcode * 397) + Status.GetHashCode();
      }
      if(__isset.operationState)
      {
        hashcode = (hashcode * 397) + OperationState.GetHashCode();
      }
      if((SqlState != null) && __isset.sqlState)
      {
        hashcode = (hashcode * 397) + SqlState.GetHashCode();
      }
      if(__isset.errorCode)
      {
        hashcode = (hashcode * 397) + ErrorCode.GetHashCode();
      }
      if((ErrorMessage != null) && __isset.errorMessage)
      {
        hashcode = (hashcode * 397) + ErrorMessage.GetHashCode();
      }
      if((TaskStatus != null) && __isset.taskStatus)
      {
        hashcode = (hashcode * 397) + TaskStatus.GetHashCode();
      }
      if(__isset.operationStarted)
      {
        hashcode = (hashcode * 397) + OperationStarted.GetHashCode();
      }
      if(__isset.operationCompleted)
      {
        hashcode = (hashcode * 397) + OperationCompleted.GetHashCode();
      }
      if(__isset.hasResultSet)
      {
        hashcode = (hashcode * 397) + HasResultSet.GetHashCode();
      }
      if((ProgressUpdateResponse != null) && __isset.progressUpdateResponse)
      {
        hashcode = (hashcode * 397) + ProgressUpdateResponse.GetHashCode();
      }
      if(__isset.numModifiedRows)
      {
        hashcode = (hashcode * 397) + NumModifiedRows.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var tmp448 = new StringBuilder("TGetOperationStatusResp(");
    if((Status != null))
    {
      tmp448.Append(", Status: ");
      Status.ToString(tmp448);
    }
    if(__isset.operationState)
    {
      tmp448.Append(", OperationState: ");
      OperationState.ToString(tmp448);
    }
    if((SqlState != null) && __isset.sqlState)
    {
      tmp448.Append(", SqlState: ");
      SqlState.ToString(tmp448);
    }
    if(__isset.errorCode)
    {
      tmp448.Append(", ErrorCode: ");
      ErrorCode.ToString(tmp448);
    }
    if((ErrorMessage != null) && __isset.errorMessage)
    {
      tmp448.Append(", ErrorMessage: ");
      ErrorMessage.ToString(tmp448);
    }
    if((TaskStatus != null) && __isset.taskStatus)
    {
      tmp448.Append(", TaskStatus: ");
      TaskStatus.ToString(tmp448);
    }
    if(__isset.operationStarted)
    {
      tmp448.Append(", OperationStarted: ");
      OperationStarted.ToString(tmp448);
    }
    if(__isset.operationCompleted)
    {
      tmp448.Append(", OperationCompleted: ");
      OperationCompleted.ToString(tmp448);
    }
    if(__isset.hasResultSet)
    {
      tmp448.Append(", HasResultSet: ");
      HasResultSet.ToString(tmp448);
    }
    if((ProgressUpdateResponse != null) && __isset.progressUpdateResponse)
    {
      tmp448.Append(", ProgressUpdateResponse: ");
      ProgressUpdateResponse.ToString(tmp448);
    }
    if(__isset.numModifiedRows)
    {
      tmp448.Append(", NumModifiedRows: ");
      NumModifiedRows.ToString(tmp448);
    }
    tmp448.Append(')');
    return tmp448.ToString();
  }
}

