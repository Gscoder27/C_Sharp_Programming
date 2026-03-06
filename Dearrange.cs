// Qns : Given an array of in numbers return number of possible derangements such that no number lies in its exact index or position

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace Dearrange
{
    class Dearrange
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Derrangements(n));
        }
        static long Derrangements(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (n == 0) return 1;
            if (n == 1) return 0;

            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 0;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = (i - 1) * (dp[i - 1] + dp[i - 2]);
            }

            return dp[n];
        }
    }
}