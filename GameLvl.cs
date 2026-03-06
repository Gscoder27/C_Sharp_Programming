using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace GameLvl
{
    class GameLvl
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x <= 0) Console.WriteLine("Invalid Input");
            string scr = "";
            int t = x;
            while (t != 0)
            {
                int n = 1;
                while (n*2 <= t)
                {
                    n *= 2;
                }
                scr += n.ToString();
                t -= n;
            }
            Console.WriteLine(scr);
            Console.ReadKey();
        }
    }
}