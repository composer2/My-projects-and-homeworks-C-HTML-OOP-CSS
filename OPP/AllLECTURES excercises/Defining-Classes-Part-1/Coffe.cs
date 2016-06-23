using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_1
{
    internal enum CoffeeSize
    {
        small = 1,
        medium = 2,
        large = 4
    }
    internal class Coffee
    {
        public CoffeeSize size;

        public Coffee(CoffeeSize size)
        {
            this.size = size;
        }

        public CoffeeSize Size { get { return size; } }
    }
}
