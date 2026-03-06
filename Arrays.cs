using System;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            // 2D Array
            Console.WriteLine("Enter 4 elements for 2D array:");

            int[,] b = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}