using System;

class Datatypes
{
    static void Main(string[] args)
    {
        /*
        Data types in C# :-
        Integer - int hr --> 4 bytes
        Long Integer - long hrr --> 8 bytes
        Floating point number - float abc = 34.5f; --> 4 bytes
        Double - double abcd = 45.67; --> 8 bytes
        Decimal - decimal abcds = 45.67m; --> 16 bytes
        Character - char ch = 'A'; --> 2 bytes
        String - string str = "Hello World"; --> 2 byte per character
        Boolean - bool isCSharpFun = true; --> 1 bit
        1 byte = 8 bits
        1 KB = 1024 bytes
        1 MB = 1024 KB
        1 GB = 1024 MB
        1 TB = 1024 GB
        1 PB = 1024 TB
        1 byte - 8 bits
        */
        
        // Console.WriteLine("Enter the name :- ");
        // string inp = Console.ReadLine();
        // int hr = 34;
        // int a = 34;
        // float b = 34.5F;
        // double c = 34.4D;
        // char ch = 'A';
        // string str = "Hello World";
        // bool isCSharpFun = true;
        // Console.WriteLine("The value of integer is : " + a);
        // Console.WriteLine("The value of float is : " + b);
        // Console.WriteLine("The value of double is : " + c);
        // Console.WriteLine("The value of char is : " + ch);
        // Console.WriteLine("The value of string is : " + str);
        // Console.WriteLine("The name is : " + inp);
        // Console.WriteLine("The value of boolean is : " + isCSharpFun);

        // Type Casting

        int x = (int)3.5;
        Console.WriteLine("The value of x is : " + x);

        // Types of casting
        // 1. Implicit Casating - char to int to long to float to double
        // 2. Explicit Casting - double to float to long to int to char (we have to manually convert it) 

        double x1 = (double)3.5;
        Console.WriteLine("The value of x1 is : " + x1);

        // float vart = Convert.ToInt32(3.55);
        float vart = Convert.ToInt64(3.55);
        // Convert.ToString
        // Convert.ToDouble

        // string x2 = "32 is amazing";
        // float y2 = float.Parse(x2);

        double y = x;
        int z = 'u';
        Console.WriteLine("The value of z is : " + z);
        Console.WriteLine("The value of y is : " + y);

        Console.WriteLine("How many candies do you want?");
        // int can = Console.Read(); // ASCII value of first character will be taken
        int can = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You will get 4 more candies :- " + (can + 4));

        // M-2 :-
        // string can = Console.ReadLine();
        // Console.WriteLine("You will get 4 more candies" + (Convert.ToInt32(can) + 4));

        // Console.ReadKey(); // to hold the console window
        Console.ReadLine(); // to hold the console window
    }
}