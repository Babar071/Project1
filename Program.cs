using System;

namespace _10_methods_of_data
{
    internal class Program
    {
        
    // Method 1: Addition
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Method 2: Subtraction
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    // Method 3: Multiplication
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    // Method 4: Division 
    public static int Divide(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        
        else
        {
            Console.WriteLine("You can not divide by zero,");
            return 0;
        }
    }

    // Method 5: Factorial
    public static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    // Method 6: Even number
    public static bool EvenorNot(int num)
    {
        return num / 2 == 0;
    }

    // Method 7: Prime number
    public static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num / i == 0)
            {
                return false;
            }
        }

        return true;
    }

    // Method 8: Taking Square
    public static int Square(int num)
    {
        return num * num;
    }

    // Method 9: Taking Cube
    public static int Cube(int num)
    {
        return num * num * num;
    }

    // Method 10: Sentence
    public static void Statement(string name)
    {
        Console.WriteLine("My name is " + name + "!");
    }

    public static void Main()
    {
        Console.WriteLine("Addition: " + Add(5, 3));
        Console.WriteLine("Subtraction: " + Subtract(8, 2));
        Console.WriteLine("Multiplication: " + Multiply(4, 6));
        Console.WriteLine("Division: " + Divide(10, 2));
        Console.WriteLine("Factorial of 5: " + Factorial(5));
        Console.WriteLine("Is 7 even? " + EvenorNot(7));
        Console.WriteLine("Is 11 prime? " + IsPrime(11));
        Console.WriteLine("Square of 4: " + Square(4));
        Console.WriteLine("Cube of 3: " + Cube(3));
        Statement("Babar");
    }
}

    }
