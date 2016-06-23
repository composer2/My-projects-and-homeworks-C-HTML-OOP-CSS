using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2
{
    internal struct Indexer
    {
        public const int BitsCount = 32;
        public uint bitValues;

        public int this[int index]
        {
            get
            {
                if ((index >= 0) && (index < BitsCount))
                {
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
                    throw new ArgumentOutOfRangeException("out of range -  invalid index");
                }
            }
            set
            {
                if (index<0||index>BitsCount-1)
                {
                    throw new ArgumentOutOfRangeException("Invalid index");
                }
                if (value<0||value>1)
                {
                    throw new ArgumentException("Invalid value- 0 or 1");
                }
                // Clear the bit at position index
                bitValues &= ~((uint)(1 << index));
                // Set the bit at position index to value
                bitValues |= (uint)(value << index);
            }
        }
    }
}
