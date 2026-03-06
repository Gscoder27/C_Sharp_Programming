using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;

namespace ModifyString
{
    class ModifyString
    {

        static string RemoveDupli(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            int len = str.Length;
            var sb = new StringBuilder();
            int i = 0;
            while (i < len)
            {
                int j = i + 1;
                while (j < len && str[i] == str[j]) j++;

                int runlen = j - i;
                if (runlen >= 2)
                {
                    if (sb.Length == 0 || sb[sb.Length - 1] != '#') sb.Append('#');
                }
                else
                {
                    sb.Append(str[i]);
                }
                i = j;
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine() ??"";
            Console.WriteLine($"Modified string: {RemoveDupli(str)}");
            Console.ReadKey();
        }
    }
}