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


public partial class TProgressUpdateResp : TBase
{

  public List<string> HeaderNames { get; set; }

  public List<List<string>> Rows { get; set; }

  public double ProgressedPercentage { get; set; }

  /// <summary>
  /// 
  /// <seealso cref="global::.TJobExecutionStatus"/>
  /// </summary>
  public TJobExecutionStatus Status { get; set; }

  public string FooterSummary { get; set; }

  public long StartTime { get; set; }

  public TProgressUpdateResp()
  {
  }

  public TProgressUpdateResp(List<string> headerNames, List<List<string>> @rows, double progressedPercentage, TJobExecutionStatus @status, string footerSummary, long startTime) : this()
  {
    this.HeaderNames = headerNames;
    this.Rows = @rows;
    this.ProgressedPercentage = progressedPercentage;
    this.Status = @status;
    this.FooterSummary = footerSummary;
    this.StartTime = startTime;
  }

  public TProgressUpdateResp DeepCopy()
  {
    var tmp520 = new TProgressUpdateResp();
    if((HeaderNames != null))
    {
      tmp520.HeaderNames = this.HeaderNames.DeepCopy();
    }
    if((Rows != null))
    {
      tmp520.Rows = this.Rows.DeepCopy();
    }
    tmp520.ProgressedPercentage = this.ProgressedPercentage;
    tmp520.Status = this.Status;
    if((FooterSummary != null))
    {
      tmp520.FooterSummary = this.FooterSummary;
    }
    tmp520.StartTime = this.StartTime;
    return tmp520;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_headerNames = false;
      bool isset_rows = false;
      bool isset_progressedPercentage = false;
      bool isset_status = false;
      bool isset_footerSummary = false;
      bool isset_startTime = false;
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
                var _list521 = await iprot.ReadListBeginAsync(cancellationToken);
                HeaderNames = new List<string>(_list521.Count);
                for(int _i522 = 0; _i522 < _list521.Count; ++_i522)
                {
                  string _elem523;
                  _elem523 = await iprot.ReadStringAsync(cancellationToken);
                  HeaderNames.Add(_elem523);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_headerNames = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.List)
            {
              {
                var _list524 = await iprot.ReadListBeginAsync(cancellationToken);
                Rows = new List<List<string>>(_list524.Count);
                for(int _i525 = 0; _i525 < _list524.Count; ++_i525)
                {
                  List<string> _elem526;
                  {
                    var _list527 = await iprot.ReadListBeginAsync(cancellationToken);
                    _elem526 = new List<string>(_list527.Count);
                    for(int _i528 = 0; _i528 < _list527.Count; ++_i528)
                    {
                      string _elem529;
                      _elem529 = await iprot.ReadStringAsync(cancellationToken);
                      _elem526.Add(_elem529);
                    }
                    await iprot.ReadListEndAsync(cancellationToken);
                  }
                  Rows.Add(_elem526);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_rows = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.Double)
            {
              ProgressedPercentage = await iprot.ReadDoubleAsync(cancellationToken);
              isset_progressedPercentage = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.I32)
            {
              Status = (TJobExecutionStatus)await iprot.ReadI32Async(cancellationToken);
              isset_status = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.String)
            {
              FooterSummary = await iprot.ReadStringAsync(cancellationToken);
              isset_footerSummary = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 6:
            if (field.Type == TType.I64)
            {
              StartTime = await iprot.ReadI64Async(cancellationToken);
              isset_startTime = true;
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
      if (!isset_headerNames)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_rows)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_progressedPercentage)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_status)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_footerSummary)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_startTime)
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
      var tmp530 = new TStruct("TProgressUpdateResp");
      await oprot.WriteStructBeginAsync(tmp530, cancellationToken);
      var tmp531 = new TField();
      if((HeaderNames != null))
      {
        tmp531.Name = "headerNames";
        tmp531.Type = TType.List;
        tmp531.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp531, cancellationToken);
        await oprot.WriteListBeginAsync(new TList(TType.String, HeaderNames.Count), cancellationToken);
        foreach (string _iter532 in HeaderNames)
        {
          await oprot.WriteStringAsync(_iter532, cancellationToken);
        }
        await oprot.WriteListEndAsync(cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((Rows != null))
      {
        tmp531.Name = "rows";
        tmp531.Type = TType.List;
        tmp531.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp531, cancellationToken);
        await oprot.WriteListBeginAsync(new TList(TType.List, Rows.Count), cancellationToken);
        foreach (List<string> _iter533 in Rows)
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, _iter533.Count), cancellationToken);
          foreach (string _iter534 in _iter533)
          {
            await oprot.WriteStringAsync(_iter534, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteListEndAsync(cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      tmp531.Name = "progressedPercentage";
      tmp531.Type = TType.Double;
      tmp531.ID = 3;
      await oprot.WriteFieldBeginAsync(tmp531, cancellationToken);
      await oprot.WriteDoubleAsync(ProgressedPercentage, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      tmp531.Name = "status";
      tmp531.Type = TType.I32;
      tmp531.ID = 4;
      await oprot.WriteFieldBeginAsync(tmp531, cancellationToken);
      await oprot.WriteI32Async((int)Status, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if((FooterSummary != null))
      {
        tmp531.Name = "footerSummary";
        tmp531.Type = TType.String;
        tmp531.ID = 5;
        await oprot.WriteFieldBeginAsync(tmp531, cancellationToken);
        await oprot.WriteStringAsync(FooterSummary, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      tmp531.Name = "startTime";
      tmp531.Type = TType.I64;
      tmp531.ID = 6;
      await oprot.WriteFieldBeginAsync(tmp531, cancellationToken);
      await oprot.WriteI64Async(StartTime, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
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
    if (!(that is TProgressUpdateResp other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return TCollections.Equals(HeaderNames, other.HeaderNames)
      && TCollections.Equals(Rows, other.Rows)
      && global::System.Object.Equals(ProgressedPercentage, other.ProgressedPercentage)
      && global::System.Object.Equals(Status, other.Status)
      && global::System.Object.Equals(FooterSummary, other.FooterSummary)
      && global::System.Object.Equals(StartTime, other.StartTime);
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if((HeaderNames != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(HeaderNames);
      }
      if((Rows != null))
      {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Rows);
      }
      hashcode = (hashcode * 397) + ProgressedPercentage.GetHashCode();
      hashcode = (hashcode * 397) + Status.GetHashCode();
      if((FooterSummary != null))
      {
        hashcode = (hashcode * 397) + FooterSummary.GetHashCode();
      }
      hashcode = (hashcode * 397) + StartTime.GetHashCode();
    }
    return hashcode;
  }

  public override string ToString()
  {
    var sb = new StringBuilder("TProgressUpdateResp(");
    if((HeaderNames != null))
    {
      sb.Append(", HeaderNames: ");
      sb.Append(HeaderNames);
    }
    if((Rows != null))
    {
      sb.Append(", Rows: ");
      sb.Append(Rows);
    }
    sb.Append(", ProgressedPercentage: ");
    sb.Append(ProgressedPercentage);
    sb.Append(", Status: ");
    sb.Append(Status);
    if((FooterSummary != null))
    {
      sb.Append(", FooterSummary: ");
      sb.Append(FooterSummary);
    }
    sb.Append(", StartTime: ");
    sb.Append(StartTime);
    sb.Append(')');
    return sb.ToString();
  }
}

