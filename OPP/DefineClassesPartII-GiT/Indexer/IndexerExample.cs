using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public struct BitArray32
    {
        public const int BitsCount = 32;
        private uint bitValues;

        //indexer declaration
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < BitsCount)
                {
                    //check the bit at position index
                    if ((bitValues & (1 << index)) == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException(string.Format("Index {0} is invalid", index));
                }
            }
            set
            {
                if (index < 0 || index > BitsCount - 1)
                {
                    throw new IndexOutOfRangeException(string.Format("Index {0} is invalid", index));
                }
                if (value < 0 || value > 1)
                {
                    throw new IndexOutOfRangeException(string.Format("Value {0} is invalid", value));
                }
                //clear the bit at position index
                bitValues &= ~((uint)(1 << index));
                //set the bit at position index to value
                bitValues |= (uint)(value << index);
            }
        }
    }
    class IndexerExample
    {
        static void Main(string[] args)
        {
            BitArray32 bits = new BitArray32();

            bits[0] = 1;
            bits[5] = 1;
            bits[5] = 0;
            bits[25] = 1;
            bits[31] = 1;

            for (int i = 0; i <= 31; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, bits[i]);
            }
            Console.Write("bits = ");
            for (int i = 0; i <= 31; i++)
            {
                Console.Write(bits[i]);
            }
            Console.WriteLine();
        }
    }
}
