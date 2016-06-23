using System;
using System.Linq;
using System.Reflection;
using AllClassesAndStructs;


namespace VersionAttribute
{
    [AllClassesAndStructs.Version("7.11")]
    public class VersionAttributeTest
    {
        static void Main(string[] args)
        {
            string version = typeof(VersionAttributeTest).GetCustomAttributes<AllClassesAndStructs.Version>().First().Ver;
            Console.WriteLine(version);
        }
    }
}
