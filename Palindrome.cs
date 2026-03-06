using System;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Invalid Input");
            else
            {
                int r = n, rev=0;
                while (r != 0)
                {
                    int temp = r % 10;
                    rev = rev * 10 + temp;
                    r /= 10;
                }

                if(rev==n) Console.WriteLine("Palindrome");
                else Console.WriteLine("Not a Palindrome");
            }
        }
    }
}