using System;

namespace Pat
{
    class Pat
    {
        static void Main(string[] args)
        {
            // Printing patterns
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}