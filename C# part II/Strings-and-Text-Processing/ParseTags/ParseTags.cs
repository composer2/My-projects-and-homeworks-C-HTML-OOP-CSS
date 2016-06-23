using System;
using System.Text.RegularExpressions;

namespace ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            //<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
            string startTag = "\">";
            string endTag = "</a>";
            string hrefToChange = "<a href=\"";
            var startIndexForText = text.IndexOf(startTag);
            var endIndexForText = text.IndexOf(endTag);
            var indexOfhrefTo = text.IndexOf(hrefToChange);

            while (startIndexForText != -1 || endIndexForText != -1 || indexOfhrefTo != -1)
            {
                string toMoveText = text.Substring(startIndexForText + 2, endIndexForText - startIndexForText - 2);
                string toDeleteText = startTag + toMoveText + endTag;

                text = text.Insert(indexOfhrefTo, "[" + toMoveText + "]").Replace(toDeleteText, ")");

                startIndexForText = text.IndexOf(startTag, startIndexForText + toMoveText.Length + 3);
                endIndexForText = text.IndexOf(endTag, endIndexForText + toMoveText.Length + 3);
                indexOfhrefTo = text.IndexOf(hrefToChange, indexOfhrefTo + toMoveText.Length + 3);
            }
            text = text.Replace(hrefToChange, "(");
            Console.WriteLine(text);
        }
    }
}