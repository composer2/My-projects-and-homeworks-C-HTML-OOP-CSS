using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Tomcat : Cat
    {
        public override int Speed
        {
            get
            {
                return 20;
            }
        }

        public override string GetName()
        {
            return "tomcat";
        }

        public override void SayMyauu()
        {
            Console.WriteLine("Tomcar mauyyyy");
        }
    }
}
