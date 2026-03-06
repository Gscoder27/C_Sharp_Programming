using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;

namespace ValidPermut
{
    class ValidPermut {
        static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        Array.Sort(arr);

        int ops = 0;
        for (int i = 0; i < n; i++)
        {
            int target = i + 1; // valid permutation number
            if (arr[i] > target)
            {
                Console.WriteLine("Impossible to form a permutation");
                return;
            }
            ops += (target - arr[i]);
        }

        Console.WriteLine("The no. of operations required = " + ops);
            Console.ReadKey();
        }
    }
}