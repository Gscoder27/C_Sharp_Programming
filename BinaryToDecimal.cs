using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int base1 = 1;
            int temp = num;
            while (temp != 0)
            {
                int lstdig = temp % 10;
                sum += lstdig * (int)(Math.Pow(2, base1 - 1));
                base1++;
                temp /= 10;
            }

            Console.WriteLine("The binary to decimal answer is : " + sum);
        }
    }
}