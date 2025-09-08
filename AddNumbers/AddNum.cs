using System;

class AddNum
{
    static public void Main(string[] args)
    {
        int num1, num2, sum;
        // Predefined input:-
        int a = 45;
        int b = 76;
        int add = a + b;
        // User input
        Console.WriteLine("Enter First Number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        sum = num1 + num2;
        Console.Write("Prints the text on the same line. ");
        Console.WriteLine("The Sum of {0} and {1} is: {2}", num1, num2, sum);
        Console.WriteLine("The Sum of {0} and {1} is: {2}", a, b, add);
        // WriteLine in nxt line and Write prints msg on the same line
        Console.ReadKey(); // to hold the console window
        Console.ReadLine(); // to hold the console window
    }
}