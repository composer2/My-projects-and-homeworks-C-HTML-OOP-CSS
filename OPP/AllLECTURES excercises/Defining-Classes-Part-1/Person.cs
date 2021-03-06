﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_1
{
    internal class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.name = null;
            this.age = 0;
        }


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
    }
}
