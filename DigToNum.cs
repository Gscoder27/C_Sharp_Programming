using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace DigToNum{
    class DigToNum
    {
        static string ConvertToWrd(int n)
        {
            if (n == 0) return "Zero";
            string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] thousands = { "", "Thousand", "Million", "Billion" };
            string res = "";
            int grp = 0;

            while (n != 0)
            {
                if (n % 1000 != 0)
                {
                    int val = n % 1000;
                    string str = "";

                    if (val >= 100)
                    {
                        str = units[val / 100] + "Hundred ";
                        val %= 100;
                    }

                    if (val >= 20)
                    {
                        str += tens[val / 10] + " ";
                        val %= 10;
                    }

                    if (val > 0)
                    {
                        str += units[val] + " ";
                    }

                    str += thousands[grp] + " ";
                    res = str + res;
                }
                n /= 1000;
                grp++;
            }
            return res.Trim();
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ConvertToWrd(n));
            Console.ReadKey();
        }
    }
}