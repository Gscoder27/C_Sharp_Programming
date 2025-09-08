using System;

class Operators
{
    static void Main(string[] args)
    {
        /*
        Operators in C# :-
        1. Arithmetic Operators - +, -, *, /, %, ++, --
        2. Assignment Operators - =, +=, -=, *=, /=, %=
        3. Comparison Operators - ==, !=, >, <, >=, <=
        4. Logical Operators - &&, ||, !
        5. Bitwise Operators - &, |, ^, ~, <<, >>
        6. Other Operators - sizeof, typeof, is, as, ?? 
        */

        // int a = 34;
        // int b = 45;

        // Arithmetic Operators
        // Console.WriteLine("The value of a + b is : " + (a + b));
        // Console.WriteLine("The value of a - b is : " + (a - b));
        // Console.WriteLine("The value of a * b is : " + (a * b));
        // Console.WriteLine("The value of a / b is : " + (a / b));
        // Console.WriteLine("The value of a % b is : " + (a % b));
        // Console.WriteLine("The value of ++a is : " + (++a));
        // Console.WriteLine("The value of --b is : " + (--b));

        // Assignment Operators
        // int c = 34;
        // c += 1; // c = c + 1
        // Console.WriteLine("The value of c after c += 1 is : " + c);
        // c -= 1; // c = c - 1
        // Console.WriteLine("The value of c after c -= 1 is : " + c);
        // c *= 2; // c = c * 2
        // Console.WriteLine("The value of c after c *= 2 is : " + c);
        // c /= 2; // c = c / 2
        // Console.WriteLine("The value of c after c /= 2 is : " + c);
        // c %= 2/; // c = c % 2
        // Console.WriteLine("The value of c after c %= 2 is : " + c);

        // Comparison Operators
        // Console.WriteLine("The value of a == b is : " + (a == b));
        // Console.WriteLine("The value of a != b is : " + (a != b));
        // Console.WriteLine("The value of a > b is : " + (a > b));
        // Console.WriteLine("The value of a < b is : " + (a < b));
        // Console.WriteLine("The value of a >= b is : " + (a >= b));
        // Console.WriteLine("The value of a <= b is : " + (a <= b));

        // Logical Operators
        // bool x = true;
        // bool y = false;
        // Console.WriteLine("The value of x && y is : " + (x && y));
        // Console.WriteLine("The value of x || y is : " + (x || y));
        // Console.WriteLine("The value of !x is : " + (!x));

        // Bitwise Operators
        // int p = 5;  // 0101 in binary
        // int q = 3;  // 0011 in binary
        // Console.WriteLine("The value of p & q is : " + (p & q));   // 0001 in binary
        // Console.WriteLine("The value of p | q is : " + (p | q));   // 0111 in binary
        // Console.WriteLine("The value of p ^ q is : " + (p ^ q));   // 0110 in binary
        // Console.WriteLine("The value of ~p is : " + (~p));         // 1010 in binary (two's complement)
        // Console.WriteLine("The value of p << 1 is : " + (p << 1)); // 1010 in binary
        // Console.WriteLine("The value of p >> 1 is : " + (p >> 1)); // 0010 in binary

        // Other Operators
        // Console.WriteLine("The size of int is : " + sizeof(int) + " bytes");
        // Console.WriteLine("The type of a is : " + a.GetType());
        // object obj = a;
        // if (obj is int)
        // {
        //     Console.WriteLine("obj is an integer");
        // }
        // string str = obj as string; // This will be null since obj is not a string
        // Console.WriteLine("The value of str is : " + str);
        // string? nullableStr = null;
        // string result = nullableStr ?? "Default Value";
        // Console.WriteLine("The value of result is : " + result);

        // Math operations
        int mn = Math.Min(43, -5);
        Console.WriteLine("The minimum value is : " + mn);
        int mx = Math.Max(43, -5);
        double sq = Math.Sqrt(36);
        double pw = Math.Pow(3, 4);
        double ab = Math.Abs(-34.5);
        Console.WriteLine("The maximum value is : " + mx);
        Console.WriteLine("The square root value is : " + sq);
        Console.WriteLine("The power value is : " + pw);
        Console.WriteLine("The absolute value is : " + ab); 
    }
}