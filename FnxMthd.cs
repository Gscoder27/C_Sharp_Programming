using System;

namespace FnxMthd
{
    class FnMthd
    {

        static int avg(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

        static float avg(int a, int b)
        {
            return (a + b) / 2.0f;
        }
        static void Main(string[] args)
        {
            /*
            Function and Methods in C# :-
            1. Function without parameters and without return type
            2. Function with parameters and without return type
            3. Function without parameters and with return type
            4. Function with parameters and with return type
            */

            // Function without parameters and without return type
            void Greet()
            {
                Console.WriteLine("Hello, Welcome to C# Programming!");
            }
            Greet();

            // Function with parameters and without return type
            void GreetUser(string name)
            {
                Console.WriteLine($"Hello, {name}! Welcome to C# Programming!");
            }
            GreetUser("Alice");

            // Function without parameters and with return type
            int GetCurrentYear()
            {
                return DateTime.Now.Year;
            }
            int year = GetCurrentYear();
            Console.WriteLine($"Current Year: {year}");

            // Function with parameters and with return type
            int Add(int a, int b)
            {
                return a + b;
            }
            int sum = Add(5, 10);

            int average = avg(10, 20, 30);
            Console.WriteLine($"Average: {average}");
            float avg1 = avg(15, 25);
            Console.WriteLine($"Average1: {avg1}");

            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }
    }
}