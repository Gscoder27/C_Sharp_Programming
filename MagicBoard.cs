using System;
namespace MagicBoard{
    class MagicBoard
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + "-" + (char)arr[i]);
            }
            Console.ReadLine();
        }
    }
}