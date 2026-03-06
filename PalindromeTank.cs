using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace PalindromeTank
{
    class PalindromeTank
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[N];

            int[] ans = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = Console.ReadLine() ?? string.Empty;
                // ans[i] = arr[i][arr[i].Length - 1] - '0';
                ans[i] = int.Parse(arr[i].Split('.')[1]);
            }

            int rightSum = 0;
            int totalSum = 0;
            for (int i = 0; i < N; i++)
            {
                totalSum += ans[i];
            }
            
            // Prefix sum to speed up calculations
        int[] prefix = new int[n];
        prefix[0] = digits[0];
        for (int i = 1; i < n; i++)
            prefix[i] = prefix[i - 1] + digits[i];

        int totalSum = prefix[n - 1];

        for (int i = 0; i < n; i++)
        {
            int leftSum = (i == 0) ? 0 : prefix[i - 1];
            int rightSum = totalSum - prefix[i];
            if (leftSum == digits[i] + rightSum)
                return tanks[i];
        }

        return "Not Found";

            // for (int i = 0; i < N; i++)
            // {
            //     int leftSum = 0;
            //     for (int j = 0; j < i; j++)
            //         leftSum += ans[j];

            //     int rightSum = totalSum - leftSum - ans[i];

            //     if (leftSum == rightSum + ans[i])
            //     {
            //         Console.WriteLine(arr[i]); // print the tank value
            //         return;
            //     }
            // }

            // Console.WriteLine("Not Found");

            Console.ReadKey();
        }
    }
}