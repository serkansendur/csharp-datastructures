using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StringExample
{
    public static void Execute()
    {
        Console.WriteLine("permute serkan");
        Permute("abcd");
    }

    public static char FindTheFirstNonRepeatingChar(string word)
    {
        char empty = '\0';

        Dictionary<char, int> _word = new Dictionary<char, int>();

        foreach (char c in word)
        {
            if (_word.ContainsKey(c))
            {
                _word[c]++;
            }
            else
            {
                _word.Add(c, 1);
            }

        }

        foreach (var item in _word)
        {
            if (item.Value == 1)
                return item.Key;
        }

        return empty;
    }

    public static string RemoveChars(string charsToBeRemoved, string word)
    {
        foreach (char c in word)
        {
            if (charsToBeRemoved.Contains(c))
                word = word.Replace(c,'\0');
        }
        return word;
    }

    public static string ReverseWords(string words)
    {
        string[] _words = words.Split(new char[] { ' ' });
        StringBuilder sb = new StringBuilder();
        for (int i = _words.Length - 1; i > -1; i--)
        {
            sb.Append(_words[i] + " ");
        }
        return sb.ToString();
    }

    public static void Permute(string str)
    {
        int length = str.Length;
        bool[] used = new bool[length];
        StringBuilder output = new StringBuilder();
        doPermute(str, output, used, length, 0);
    }

    public static void doPermute(string input, StringBuilder output,
        bool[] used, int length, int level)
    {
        if (level == length)
        {
            Console.WriteLine(output.ToString());
            return;
        }

        for(int i=0; i< length;i++)
        {
            if (used[i])
                continue;

            output.Append(input[i]);
            used[i] = true;
            doPermute(input, output, used, length, level + 1);
            used[i] = false;

            output.Length = output.Length - 1;


        }
    }


}

