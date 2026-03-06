using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ImpactSum {
    class ImpactSum
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int C = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                int imptSm = sum - arr[i];
                if (imptSm > C) Console.Write(C + ",");
                else Console.Write(imptSm + ",");
            }
            Console.ReadKey();
        }
    }
}

