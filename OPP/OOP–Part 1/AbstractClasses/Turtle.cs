using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Turtle : Animal
    {
        public override int Speed
        {
            get
            {
                return 1;
            }
        }
        public override string GetName()
        {
            return "turtle";
        }
    }
}
