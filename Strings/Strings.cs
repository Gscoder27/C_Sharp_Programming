using System;

class Strings
{
    static void Main(string[] args)
    {
        string hlo = "Hello gurry";
        string name = Console.ReadLine() ?? string.Empty;
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(hlo.Length);
        Console.WriteLine(hlo.ToUpper());
        Console.WriteLine(hlo.ToLower());
        Console.WriteLine(hlo.Contains("gurry"));
        Console.WriteLine(hlo[0]);
        Console.WriteLine(hlo.IndexOf("gurry"));
        Console.WriteLine(hlo.Substring(6));
        Console.WriteLine(hlo.Replace("gurry", "world"));
        Console.WriteLine(hlo.Split(" ")[0]);
        Console.WriteLine(hlo + " How are you?");
        Console.WriteLine(string.Concat(hlo, " How are you?"));
        // Console.WriteLine(hlo + ' ' + "How are you?");
        Console.WriteLine($"Your name is {name}. your age is {age}");
        Console.WriteLine(string.Join(" ", hlo, "How are you?"));
        Console.WriteLine(string.Format("{0} {1}", hlo, "How are you?"));
        Console.WriteLine($"Hello gurry How are you?");
        Console.WriteLine(hlo.Trim());
        Console.WriteLine(hlo.TrimStart());
        Console.WriteLine(hlo.TrimEnd());
        Console.WriteLine(hlo.PadLeft(20, '*'));
        Console.WriteLine(hlo.PadRight(20, '*'));
        Console.WriteLine(string.IsNullOrEmpty(hlo));
        Console.WriteLine(string.IsNullOrWhiteSpace(hlo));
        Console.WriteLine(hlo.GetType());
        Console.WriteLine(hlo.CompareTo("Hello gurry"));
        Console.WriteLine(hlo.CompareTo("Hello world"));
        Console.WriteLine(hlo.Equals("Hello gurry"));
        Console.WriteLine(hlo.Equals("Hello world"));
        Console.WriteLine(hlo.GetHashCode());

        // escape sequences characters in strings
        string tk = "Hello world this \'' is Jassi";
        Console.WriteLine(tk);
        string tk1 = "Hello world this \\ is Jassi";
        Console.WriteLine(tk1);
        string tk2 = "Hello world this \n is Jassi";
        Console.WriteLine(tk2);

        Console.ReadLine();
    }
}