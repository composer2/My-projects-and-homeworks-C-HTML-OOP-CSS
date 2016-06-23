using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            //http://telerikacademy.com/Courses/Courses/Details/212
            var url = Console.ReadLine().Split(new string []{ "//"},StringSplitOptions.RemoveEmptyEntries);
            var indexSlash = url[1].IndexOf("/");
            
            var http = url[0].Substring(0,url[0].Length-1);
            var dotcom = url[1].Substring(0,indexSlash);
            var slash = url[1].Substring(indexSlash);

            Console.WriteLine("[protocol] = {0}", http);
            Console.WriteLine("[server] = {0}", dotcom);
            Console.WriteLine("[resource] = {0}", slash);

        }
    }
}
