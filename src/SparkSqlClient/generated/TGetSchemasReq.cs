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
    internal partial class TGetSchemasReq : TBase
    {
        private string _catalogName;
        private string _schemaName;

        public TSessionHandle SessionHandle { get; set; }

        public string CatalogName
        {
            get
            {
                return _catalogName;
            }
            set
            {
                __isset.catalogName = true;
                this._catalogName = value;
            }
        }

        public string SchemaName
        {
            get
            {
                return _schemaName;
            }
            set
            {
                __isset.schemaName = true;
                this._schemaName = value;
            }
        }


        public Isset __isset;
        public struct Isset
        {
            public bool catalogName;
            public bool schemaName;
        }

        public TGetSchemasReq()
        {
        }

        public TGetSchemasReq(TSessionHandle sessionHandle) : this()
        {
            this.SessionHandle = sessionHandle;
        }

        public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
        {
            iprot.IncrementRecursionDepth();
            try
            {
                bool isset_sessionHandle = false;
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
                                SessionHandle = new TSessionHandle();
                                await SessionHandle.ReadAsync(iprot, cancellationToken);
                                isset_sessionHandle = true;
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.String)
                            {
                                CatalogName = await iprot.ReadStringAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.String)
                            {
                                SchemaName = await iprot.ReadStringAsync(cancellationToken);
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
                if (!isset_sessionHandle)
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
                var struc = new TStruct("TGetSchemasReq");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                field.Name = "sessionHandle";
                field.Type = TType.Struct;
                field.ID = 1;
                await oprot.WriteFieldBeginAsync(field, cancellationToken);
                await SessionHandle.WriteAsync(oprot, cancellationToken);
                await oprot.WriteFieldEndAsync(cancellationToken);
                if (CatalogName != null && __isset.catalogName)
                {
                    field.Name = "catalogName";
                    field.Type = TType.String;
                    field.ID = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(CatalogName, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (SchemaName != null && __isset.schemaName)
                {
                    field.Name = "schemaName";
                    field.Type = TType.String;
                    field.ID = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(SchemaName, cancellationToken);
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
            var other = that as TGetSchemasReq;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return System.Object.Equals(SessionHandle, other.SessionHandle)
                   && ((__isset.catalogName == other.__isset.catalogName) && ((!__isset.catalogName) || (System.Object.Equals(CatalogName, other.CatalogName))))
                   && ((__isset.schemaName == other.__isset.schemaName) && ((!__isset.schemaName) || (System.Object.Equals(SchemaName, other.SchemaName))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                hashcode = (hashcode * 397) + SessionHandle.GetHashCode();
                if(__isset.catalogName)
                    hashcode = (hashcode * 397) + CatalogName.GetHashCode();
                if(__isset.schemaName)
                    hashcode = (hashcode * 397) + SchemaName.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("TGetSchemasReq(");
            sb.Append(", SessionHandle: ");
            sb.Append(SessionHandle== null ? "<null>" : SessionHandle.ToString());
            if (CatalogName != null && __isset.catalogName)
            {
                sb.Append(", CatalogName: ");
                sb.Append(CatalogName);
            }
            if (SchemaName != null && __isset.schemaName)
            {
                sb.Append(", SchemaName: ");
                sb.Append(SchemaName);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

