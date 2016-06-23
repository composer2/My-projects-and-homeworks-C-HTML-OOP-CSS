using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClassesComposition
{
    class Car
    {
        Door FrontRightDoor;
        Door FrontLeftDoor;
        Door RearRightDoor;
        Door RearLeftDoor;
        Engine engine;

        public Car()
        {
            engine = new Engine();
            engine.horsePower = 2000;
        }
        public class Engine
        {
            public int horsePower;
        }
        public class Door
        {
            public string FrontRightDoor;
            public string FrontLeftDoor;
            public string RearRightDoor;
            public string RearLeftDoor;
        }
        static void Main(string[] args)
        {

        }
    }
}
