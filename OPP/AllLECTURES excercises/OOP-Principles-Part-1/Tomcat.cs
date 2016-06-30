using System;

namespace OOP_Principles_Part_1
{
internal    class Tomcat:Cat2
    {
        public override int Speed
        {
            get
            {
                return 10;
            }
        }

        public override string GetName()
        {
            return "Tomcat";
        }

        public override void SayMyaau()
        {
            Console.WriteLine("Tomcat mayyyy");
        }
    }
}
