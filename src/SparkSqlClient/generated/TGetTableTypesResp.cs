/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;

namespace SparkSqlClient.generated
{
    internal partial class TGetTableTypesResp : TBase
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

        public TGetTableTypesResp()
        {
        }

        public TGetTableTypesResp(TStatus status) : this()
        {
            this.Status = status;
        }

        public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
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

        public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
        {
            oprot.IncrementRecursionDepth();
            try
            {
                var struc = new TStruct("TGetTableTypesResp");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                field.Name = "status";
                field.Type = TType.Struct;
                field.ID = 1;
                await oprot.WriteFieldBeginAsync(field, cancellationToken);
                await Status.WriteAsync(oprot, cancellationToken);
                await oprot.WriteFieldEndAsync(cancellationToken);
                if (OperationHandle != null && __isset.operationHandle)
                {
                    field.Name = "operationHandle";
                    field.Type = TType.Struct;
                    field.ID = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
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
            var other = that as TGetTableTypesResp;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return System.Object.Equals(Status, other.Status)
                   && ((__isset.operationHandle == other.__isset.operationHandle) && ((!__isset.operationHandle) || (System.Object.Equals(OperationHandle, other.OperationHandle))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                hashcode = (hashcode * 397) + Status.GetHashCode();
                if(__isset.operationHandle)
                    hashcode = (hashcode * 397) + OperationHandle.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("TGetTableTypesResp(");
            sb.Append(", Status: ");
            sb.Append(Status== null ? "<null>" : Status.ToString());
            if (OperationHandle != null && __isset.operationHandle)
            {
                sb.Append(", OperationHandle: ");
                sb.Append(OperationHandle== null ? "<null>" : OperationHandle.ToString());
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

