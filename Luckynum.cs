using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace Luckynum
{
    class Luckynum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string n = Console.ReadLine();
            int N = Convert.ToInt32(n);
            if (n.Length < 4) Console.WriteLine("Invalid Input");
            else
            {
                int t = N;
                int sum = 0;
                while (t != 0)
                {
                    int temp = t % 10;
                    sum += temp;
                    t /= 10;
                }
                if (sum % 3 == 0 || sum % 5 == 0 || sum % 7 == 0) Console.WriteLine("Lucky Number");
                else Console.WriteLine("Not a Lucky Number");
            }
            
            Console.ReadKey();
        }
    } 
}