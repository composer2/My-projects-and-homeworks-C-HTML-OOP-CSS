using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATastrophe
{
    class CATastrophe
    {
        static string[] loops = { "for", "while", "foreach" };
        static string[] conditions = { "if", "else if" };

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lines = new string[n];
            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            bool IsInMethod = false;
            bool IsInLoop = false;
            bool IsInCondition = false;
            var scopes = new Stack<string>(); 

            for (int i = 0; i < n; i++)
            {
                if (lines[i].Contains(" static "))
                {
                    scopes.Push("method");

                }
                else if (lines[i].Trim()=="else")
                {

                    if (scopes.Count>0)
                    {
                    scopes.Pop();
                    }
                }
                else
                {
                    var splitByBracket = lines[i].Split('(');
                    if (splitByBracket.Length!=1)
                    {
                        var keyWord = splitByBracket[0].Trim();
                        if (loops.Contains(keyWord))
                        {
                            scopes.Push("loop");
                        }
                        if (conditions.Contains(keyWord))
                        {
                            scopes.Push("conditions");
                        }
                    }
                }
                else if (lines[i].Trim()=="else")
                {
                    scopes.Push("conditions");
                }
                Console.WriteLine(i+" in scope of "+ (scopes.Count>0?scopes.Peek()));
            }
        }
    }
}
