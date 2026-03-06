using System;

class LCM
{
    static int FindGCD(int num1, int num2)
    {
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }

    static int gcd(int a, int b)
    {
        // if b=0, a is the GCD
        if (b == 0) return a;
        // call the gcd() method recursively by
        // replacing a with b and b with
        // difference(a,b) as long as b != 0
        else return gcd(b, Math.abs(a - b));
    }

    static int gcd(int a, int b)
    {
        // if b=0, a is the GCD
        if (b == 0) return a;
        // call the gcd() method recursively by
        // replacing a with b and b with
        // modulus(a,b) as long as b != 0
        else return gcd(b, a % b);
    }

    static int FindLCM(int num1, int num2)
    {
        int gcd = FindGCD(num1, num2);
        return (num1 * num2) / gcd;
    }

    static void Main()
    {
        int number1 = 12;
        int number2 = 18;
        int lcm = FindLCM(number1, number2);
        Console.WriteLine($"LCM of {number1} and {number2} is: {lcm}");
    }
}   