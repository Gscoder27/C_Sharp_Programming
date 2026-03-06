using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine() ?? string.Empty;
            int n = s.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = n - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            string res = sb.ToString();
            Console.WriteLine("The reverse string is " + res);
        }
    }
}