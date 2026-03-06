using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Numerics;

namespace LuckyJerseyNum
{
    class LuckyJerseyNum
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int mxRow = -999999, mxCol = -999999;
            int[,] arr = new int[n, m];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                int colSum = 0;
                for (int j = 0; j < m; j++)
                {
                    colSum += arr[i, j];
                }
                mxCol = Math.Max(mxCol, colSum);
            }

            for (int i = 0; i < m; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < n; j++)
                {
                    rowSum += arr[j, i];
                }
                mxRow = Math.Max(mxRow, rowSum);
            }
            Console.WriteLine("The Luck jersey number is : " + (mxRow + mxCol));
            Console.ReadKey();
        }
    }
}