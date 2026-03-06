using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace Prime
{
    class Prime
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1) Console.WriteLine("Not Prime");

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }

            Console.WriteLine("Prime");
            Console.ReadKey();
        }
    }
}
