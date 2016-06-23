using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string sex = "male")
            : base(name, age, sex)
        { }

    }
}
