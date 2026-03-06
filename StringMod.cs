using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;

namespace StringMod{
    class StringMod{
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] S = new string[N];

            for (int i = 0; i < N; i++)
            {
                S[i] = Console.ReadLine() ?? string.Empty;
            }
            for(int k=0;k<N;k++)
            {
                // string str = Console.ReadLine() ?? string.Empty;
                int n = S[k].Length;

                char[] arr = S[k].ToCharArray();
                StringBuilder sb = new StringBuilder();

                if (n > 0)
                {
                    sb.Append(arr[0]);
                    int i = 0, j = 1;
                    while (j < n)
                    {
                        if (arr[i] == arr[j])
                        {
                            if (arr[j] == 'x')
                            {
                                sb.Append('y');
                                arr[j] = 'y';
                            }
                            else
                            {
                                sb.Append('x');
                                arr[j] = 'x';
                            }
                            i++; j++;
                        }
                        else
                        {
                            sb.Append(arr[j]);
                            i++; j++;
                        }
                    }
                }
                Console.WriteLine($"Modified string: {sb.ToString()}");
            }
            Console.ReadKey();
        }
    }
}