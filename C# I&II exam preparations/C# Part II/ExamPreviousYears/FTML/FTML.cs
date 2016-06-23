using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTML
{
    class FTML
    {
        private static string RevTagOpen = "<rev>";
        private static string UpperTagOpen = "<upper>";
        private static string LowerTagOpen = "<lower>";
        private static string ToggleTagOpen = "<toggle>";
        private static string DelTagOpen = "<del>";

        private static string RevTagClose = "</rev>";
        private static string UpperTagClose = "</upper>";
        private static string LowerTagClose = "</lower>";
        private static string ToggleTagClose = "</toggle>";
        private static string DelTagClose = "</del>";
        private static StringBuilder output = new StringBuilder();
        private static int openedDelTags = 0;
        private static List<string> currentOpenedTags = new List<string>();
        private static List<int> revTagStarts = new List<int>();
        static void Main(string[] args)
        {
            int numberOflines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOflines; i++)
            {
                string currLine = Console.ReadLine();
                int currSymbolIndex = 0;

                while (currSymbolIndex < currLine.Length)
                {
                    if (currLine[currSymbolIndex] == '<')
                    {
                        string tag = GetTag(currLine, currSymbolIndex);
                        ProcessTag(tag);

                        currSymbolIndex += tag.Length - 1;
                    }
                    else
                    {
                        if (openedDelTags == 0)
                        {
                            char symbolToAdd = currLine[currSymbolIndex];
                            for (int j = currentOpenedTags.Count - 1; j >= 0; j--)
                            {
                                symbolToAdd = ApplyEffect(symbolToAdd, currentOpenedTags[j]);
                            }
                            output.Append(symbolToAdd);
                        }
                    }
                    currSymbolIndex++;
                }
                output.Append('\n');
            }
            Console.WriteLine(output.ToString().Trim());
        }

        private static char ApplyEffect(char symbolToAdd, string currOpenTag)
        {

            if (char.IsLetter(symbolToAdd))
            {
                if (currOpenTag == UpperTagOpen)
                {
                    symbolToAdd = char.ToUpper(symbolToAdd);

                }
                else if (currOpenTag == LowerTagOpen)
                {
                    symbolToAdd = char.ToLower(symbolToAdd);

                }
                else if (currOpenTag == ToggleTagOpen)
                {
                    if (char.IsLower(symbolToAdd))
                    {
                        symbolToAdd = char.ToUpper(symbolToAdd);
                    }
                    else
                    {
                        symbolToAdd = char.ToLower(symbolToAdd);
                    }
                }
            }
            return symbolToAdd;
        }

        private static void ProcessTag(string tag)
        {
            if (tag == DelTagOpen)
            {
                openedDelTags++;
            }
            else if (tag == DelTagClose)
            {
                openedDelTags--;
            }
            else
            {
                if (openedDelTags == 0)
                {
                    if (tag == RevTagOpen)
                    {
                        revTagStarts.Add(output.Length);
                    }
                    else if (tag == RevTagClose)
                    {
                        int currRevStart = revTagStarts[revTagStarts.Count - 1];
                        int revEnd = output.Length - 1;
                        Reverse(currRevStart, revEnd);
                        revTagStarts.RemoveAt(revTagStarts.Count - 1);
                    }
                    else if (tag[1] == '/')
                    {
                        currentOpenedTags.RemoveAt(currentOpenedTags.Count - 1);
                    }
                    else
                    {
                        currentOpenedTags.Add(tag);
                    }
                }
            }
        }

        private static void Reverse(int currRevStart, int revEnd)
        {
            int start = currRevStart;
            int end = revEnd;

            while (start < end)
            {
                char bufferChar = output[start];
                output[start] = output[end];
                output[end] = bufferChar;
                end--;
                start++;
            }
        }

        private static string GetTag(string currLine, int symbolIndex)
        {
            int tagStart = symbolIndex;
            int tagEnd = currLine.IndexOf('>', tagStart + 1);

            string tag = currLine.Substring(tagStart, tagEnd - tagStart + 1);
            return tag;
        }
    }
}
