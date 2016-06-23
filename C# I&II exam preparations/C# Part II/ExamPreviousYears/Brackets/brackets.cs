using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class brackets
    {
        static StringBuilder sb = new StringBuilder();
        static string tabs;
        static int countTabs = 0;
        static bool shouldPrintNewLine = false;
        static bool isFirstSymbol = true;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            tabs = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                HandleLine(line);
            }
            Console.WriteLine(sb.ToString());
        }

        private static void HandleLine(string line = "")
        {
            for (int i = 0; i < line.Length; i++)
            {
                char currentChar = line[i];
                if (shouldPrintNewLine && char.IsWhiteSpace(currentChar))
                {
                    continue;
                }
                if (shouldPrintNewLine)
                {
                    sb.AppendLine();
                    shouldPrintNewLine = false;
                    isFirstSymbol = true;
                }

                if (currentChar == '{')
                {
                    if (!shouldPrintNewLine)
                    {
                        if (!isFirstSymbol)
                        {
                            if (char.IsWhiteSpace(line[i-1]))//(sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                            {
                                sb.Remove(sb.Length - 1, 1);
                            }
                            sb.AppendLine();
                        }
                    }
                    AppendTabs();
                    sb.Append(currentChar);
                    countTabs++;
                    shouldPrintNewLine = true;
                }
                else if (currentChar == '}')
                {
                    countTabs--;
                    if (!shouldPrintNewLine)
                    {
                        if (!isFirstSymbol)
                        {
                            if (char.IsWhiteSpace(line[i - 1]))//(sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                            {
                                sb.Remove(sb.Length - 1, 1);
                            }
                            sb.AppendLine();
                        }
                    }
                    AppendTabs();
                    sb.Append(currentChar);
                    shouldPrintNewLine = true;
                }
                else
                {
                    if (isFirstSymbol)
                    {
                        AppendTabs();
                    }
                    if (!(isFirstSymbol
                        && char.IsWhiteSpace(currentChar)))
                    {
                        if (!(i < line.Length - 1
                            && char.IsWhiteSpace(line[i])
                            && char.IsWhiteSpace(line[i + 1])))
                        {
                            sb.Append(currentChar);
                        }
                    }
                    isFirstSymbol = false;
                }
            }
            shouldPrintNewLine = true;
            isFirstSymbol = true;
        }
        private static void AppendTabs()
        {
            for (int i = 0; i < countTabs; i++)
            {
                sb.Append(tabs);
            }
        }
    }
}
