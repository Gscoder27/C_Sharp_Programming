using System;

namespace DecisionControl
{
    class DecisionControl
    {
        static void Main(string[] args)
        {
            /*
            Decision Control Statements in C# :-
            1. if
            2. if-else
            3. if-else-if ladder
            4. switch-case
            5. ternary operator
            */

            int age;
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            // if statement
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }

            // if-else statement
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            // if-else-if ladder
            if (age < 13)
            {
                Console.WriteLine("You are a child.");
            }
            else if (age >= 13 && age < 20)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age >= 20 && age < 60)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }

            // switch-case statement
            Console.WriteLine("Enter a number between 1 and 5: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("You entered One.");
                    break;
                case 2:
                    Console.WriteLine("You entered Two.");
                    break;
                case 3:
                    Console.WriteLine("You entered Three.");
                    break;
                case 4:
                    Console.WriteLine("You entered Four.");
                    break;
                case 5:
                    Console.WriteLine("You entered Five.");
                    break;
                default:
                    Console.WriteLine("Number out of range.");
                    break;
            }

            // varities in switch-case

            // Calculate the category first
            // int category = age >= 18 ? 1 : 0;

            // switch (category)
            // {
            //     case 0:
            //         Console.WriteLine("Minor");
            //         break;
            //     case 1:
            //         Console.WriteLine("Adult");
            //         break;
            // }

            // switch (age)
            // {
            //     case int n when n < 13:
            //         Console.WriteLine("Child");
            //         break;
            //     case int n when n >= 13 && n < 20:
            //         Console.WriteLine("Teenager");
            //         break;
            //     case int n when n >= 20:
            //         Console.WriteLine("Adult");
            //         break;
            // }

            // ternary operator
            string eligibility = (age >= 18) ? "eligible" : "not eligible";
            Console.WriteLine($"You are {eligibility} to vote.");
            
            Console.WriteLine("\n");

            // Loops in C#

            // for loop
            for (int i = 1; i <= 5; i++)
            {
                // Console.WriteLine(j + 1);
                Console.WriteLine($"For Loop Iteration: {i}");
            }
            Console.WriteLine("\n");    

            // while loop
            int j = 1;
            while (j <= 5)
            {
                // Console.WriteLine(j + 1);
                // Console.WriteLine($"While Loop Iteration: {j}");
                // Console.WriteLine($"While Loop Iteration: " + j);
                Console.WriteLine("While Loop Iteration:" + j);
                j++;
            }

            Console.WriteLine("\n");    

            // do-while loop
            int k = 1;
            do
            {
                // Console.WriteLine(j + 1);
                Console.WriteLine($"Do-While Loop Iteration: {k}");
                k++;
            } while (k <= 5);

            // Break and continue

            for (int i = 0; i < 5; i++)
            {
                if (i == 3) break; // exits the loop when i is 3
                Console.WriteLine($"Break Example Iteration: {i}");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 5; i++)
            {
                if (i == 0) continue; // skips the iteration when i is 0
                Console.WriteLine($"Continue Example Iteration: {i}");
            }

            Console.ReadLine(); // to hold the console window
        }
    }
}