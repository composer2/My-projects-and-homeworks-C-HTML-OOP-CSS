using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultValues
{
    class defaultValues
    {
        string name;
        int age;
        int lenght;
        bool isMale;
        static void Main(string[] args)
        {
            defaultValues smntg = new defaultValues();
            Console.WriteLine(smntg.name);
            Console.WriteLine(smntg.age);
            Console.WriteLine(smntg.lenght);
            Console.WriteLine(smntg.isMale);
        }
    }
}
