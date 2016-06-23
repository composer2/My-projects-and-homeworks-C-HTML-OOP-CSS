using System;
using System.Collections.Generic;
using System.Linq;

class Konspiration
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var lines = new string[n];

        for (int i = 0; i < n; i++)
        {
            lines[i] = Console.ReadLine();
        }

        for (int i = 0; i < n; i++)
        {
            if (lines[i].Contains(" static "))
            {
                var name = lines[i].Split(new[] { ' ', '(' }, StringSplitOptions.RemoveEmptyEntries)[2];
                i += 2;
                var curlyBrackets = 1;
                var methodCalls = new List<string>();

                while (curlyBrackets > 0 && i < n)
                {
                    var splitByBracket = lines[i].Split('(');
                    if (splitByBracket.Length > 1)
                    {
                        for (int k = 0; k < splitByBracket.Length - 1; k++)
                        {
                            var methodName = ExtractMethodName(splitByBracket[k]);

                            if (methodName != null)
                            {
                                methodCalls.Add(methodName);
                            }
                        }
                    }
                    foreach (var ch in lines[i])
                    {
                        if (ch == '{')
                        {
                            curlyBrackets++;
                        }
                        else if (ch == '}')
                        {
                            curlyBrackets--;
                        }
                    }
                    i++;
                }
                if (methodCalls.Count > 0)
                {
                    Console.WriteLine(name + " -> " + methodCalls.Count + " -> " + string.Join(", ", methodCalls));

                }
                else
                {
                    Console.WriteLine(name + " -> None");
                }
            }
        }
    }
    private static string ExtractMethodName(string codePiece)
    {
        var beforeBracket = codePiece.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

        // trim operators that can precede a method invoke
        var methodName = beforeBracket[beforeBracket.Length - 1].TrimStart("<>!+-*/%^~".ToCharArray());

        if (methodName.Length == 0 || !char.IsUpper(methodName[0]) || beforeBracket.Contains("new"))
        {
            return null;
        }
        return methodName;
    }
}