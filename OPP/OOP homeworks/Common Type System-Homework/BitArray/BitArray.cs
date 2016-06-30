namespace BitArray
{
    using System;
    using System.Collections.Generic;

    class BitArray : IEnumerable<int>
    {
        public ulong Number { get; private set; }

        public BitArray(ulong number)
        {
            this.Number = number;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Out of range");
                }
                return (byte)((this.Number >> index) & 1);
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Out of range");
                }
                if (value > 1 || value < 0)
                {
                    throw new ArgumentException("Value must be 0 or 1");
                }
                if (value == 0)
                {
                    this.Number = this.Number & (ulong)(~(1 << index));
                }
                else
                {
                    this.Number = this.Number | (ulong)(1 << index);
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override bool Equals(object obj)
        {
            var num = obj as BitArray;
            if (num == null)
            {
                return false;
            }
            return this.Number == num.Number;
        }

        public static bool operator ==(BitArray bit1, BitArray bit2)
        {
            return BitArray.Equals(bit1, bit2);
        }
        public static bool operator !=(BitArray bit1, BitArray bit2)
        {
            return !BitArray.Equals(bit1, bit2);
        }
        public override int GetHashCode()
        {
            return this.Number.GetHashCode() ^ 13;
        }
    }
}
