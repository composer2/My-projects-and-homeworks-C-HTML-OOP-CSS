using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticFieldsAndMethods
{
    public class Sequence
    {
        private static int currValue = 0;

        private Sequence()
        {
        }
        public static int NextValue()
        {
            currValue++;
            return currValue;
        }
    }
    class SequenceManipulating
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequence [1..3]: {0} {1} {2}",Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());
        }
    }

}
