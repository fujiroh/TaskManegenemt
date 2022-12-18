using System;

namespace MainApp.Evm.Content
{
    public class EvmValue : IEquatable<EvmValue>
    {
        public int Second { get; }
        public double ToHour() => (double)Second / 3600;
        
        public static EvmValue Zero => new EvmValue(0);

        public EvmValue()
        {
            Second = 0;
        }
        
        public EvmValue(int second)
        {
            Second = second;
        }

        public static EvmValue Max(EvmValue v1,EvmValue v2)
        {
            return v1 > v2 ? v1 : v2;
        }

        public static EvmValue Max(params EvmValue[] values)
        {
            EvmValue maxValue = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                maxValue = Max(maxValue, values[i]);
            }
            return maxValue;
        }
        
        public static EvmValue operator +(EvmValue v1, EvmValue v2)
        {
            return new EvmValue(v1.Second + v2.Second);
        }

        public static EvmValue operator -(EvmValue v1, EvmValue v2)
        {
            return new EvmValue(v1.Second - v2.Second);
        }

        public static bool operator <(EvmValue v1, EvmValue v2)
        {
            return v1.Second < v2.Second;
        }

        public static bool operator >(EvmValue v1, EvmValue v2)
        {
            return v1.Second > v2.Second;
        }

        public static bool operator ==(EvmValue v1, EvmValue v2)
        {
            if (v1 == null)
            {
                return false;
            }
            return v1.Equals(v2);
        }

        public static bool operator !=(EvmValue v1, EvmValue v2)
        {
            return !(v1 == v2);
        }

        public bool Equals(EvmValue other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Second == other.Second;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((EvmValue) obj);
        }

        public override int GetHashCode()
        {
            return Second;
        }
    }
}