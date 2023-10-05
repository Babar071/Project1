using System;

namespace Assignment_._1
{
    internal class Program
    {
        private static int result;
        
        public static void Add(int a, int b)
        //Method1[Addition]
        {
             result = a + b;
        }
        
        public static void Sub(int a, int b)
        //Method2[Subtraction]
        {
             result = a - b;
        }
        

        public static void Multiply(int a, int b) 
            //Method3[Multiplication]
        {
             result = a * b;
        }

        public static void Divide(int a, int b)
            //Method4[Division]
        {
            if (b != 0)
            {
                result = a / b;
            }
            
            else
            {
                Console.WriteLine("You can not divide by zero.");
            }
        }

        public static void Main(string[] args)
        {
        Add(1, 2);
        Console.WriteLine("After Addition: " + result);
        
        Sub(9,4);
        Console.WriteLine("After Subtraction: " + result);
        
        Multiply(5,6);
        Console.WriteLine("After Multiplication: " + result);
        
        Divide(10,2);
        Console.WriteLine("After Division: " + result);
        }
        
    }
}