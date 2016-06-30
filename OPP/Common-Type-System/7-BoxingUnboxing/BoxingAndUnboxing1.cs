using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_BoxingUnboxing
{
    interface IMovable
    {
        void Move(int x, int y);
    }
    // Very bad practice! Structures should
    // contain no logic, but only data!
    struct Point : IMovable
    {
        public int x, y;

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    }
    class BoxingAndUnboxing1
    {
    }
}
