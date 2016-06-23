using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();
            var text = Console.ReadLine().Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            //split by dot
            var result = new StringBuilder();
            //check every sentence
            foreach (var sentence in text)
            {
                //index of the WORD
                var index = sentence.IndexOf(keyWord);
                while (index != -1)
                {
                    var beforeIndex = "";
                    if (index == 0)
                    {
                        //index of word plus one more letter infront - border case
                        beforeIndex = sentence.Substring(index, keyWord.Length + 1);//everything that is diff from letter
                        if (!char.IsLetter(beforeIndex[beforeIndex.Length - 1]))
                        {
                            result.Append(sentence + ".");
                            break;
                        }
                    }
                    else if (index == sentence.Length- keyWord.Length)
                    {
                        //index of word plus one more letter behind - border case
                        beforeIndex = sentence.Substring(index - 1, keyWord.Length + 1);//everything that is diff from letter
                        if (!char.IsLetter(beforeIndex[0]))
                        {
                            result.Append(sentence + ".");
                            break;
                        }
                    }
                    else 
                    {
                        //index of word plus two more letters behind and infront
                        beforeIndex = sentence.Substring(index - 1, keyWord.Length + 2);
                        if (!char.IsLetter(beforeIndex[beforeIndex.Length - 1]) && !char.IsLetter(beforeIndex[0]))//everything that is diff from letter
                        {
                            result.Append(sentence + ".");
                            break;
                        }
                    }
                    index = sentence.IndexOf(keyWord, index + 1);
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}