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
    internal partial class TDoubleValue : TBase
    {
        private double _value;

        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                __isset.@value = true;
                this._value = value;
            }
        }


        public Isset __isset;
        public struct Isset
        {
            public bool @value;
        }

        public TDoubleValue()
        {
        }

        public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
        {
            iprot.IncrementRecursionDepth();
            try
            {
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
                            if (field.Type == TType.Double)
                            {
                                Value = await iprot.ReadDoubleAsync(cancellationToken);
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
                var struc = new TStruct("TDoubleValue");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (__isset.@value)
                {
                    field.Name = "value";
                    field.Type = TType.Double;
                    field.ID = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteDoubleAsync(Value, cancellationToken);
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
            var other = that as TDoubleValue;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((__isset.@value == other.__isset.@value) && ((!__isset.@value) || (System.Object.Equals(Value, other.Value))));
        }

        public override int GetHashCode() {
            int hashcode = 157;
            unchecked {
                if(__isset.@value)
                    hashcode = (hashcode * 397) + Value.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("TDoubleValue(");
            bool __first = true;
            if (__isset.@value)
            {
                if(!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Value: ");
                sb.Append(Value);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}

