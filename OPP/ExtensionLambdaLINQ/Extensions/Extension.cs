using System;
using System.Collections.Generic;
using System.Text;

public static class Extension
{
    public static int WordCount(this string str)
    {
        return str.Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static string ToString<T>(this IEnumerable<T> enumeration)
    {
        var result = new StringBuilder();
        result.Append("[ ");
        foreach (var item in enumeration)
        {
            result.Append(item);
            result.Append(" ");
        }
        result.Append("]");
        return result.ToString();
    }

    public static void IncreaseInput(this IList<int> list, int amout)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] += amout;
        }
    }
}

