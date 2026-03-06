using System;
using System.Collections.Generic; // Generic collections (List<T>, Dictionary<K,V>, HashSet<T>, Queue<T>, Stack<T>, etc.)
using System.Collections.Concurrent; // Thread-safe collections (ConcurrentDictionary, ConcurrentQueue, etc.)

namespace Subarray
{
    class Subarray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int k = 3;

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int cnt = 0;

            List<List<int>> subarr = new List<List<int>>();

            for (int i = 0; i < n-(k-1); i++)
            {
                List<int> temp = new List<int>();
                for (int j = i; j < i+k; j++)
                {
                    temp.Add(arr[j]);
                }
                subarr.Add(new List<int>(temp));
            }

            foreach (var sub in subarr)
            {
                if(sub[0]+sub[2]==sub[1]) cnt++;
            }

            Console.WriteLine("The number of subarrays of size 3 who has the sum of first and last element equals to it's 2nd is : " +cnt);
            Console.ReadLine();
        }
    }
}