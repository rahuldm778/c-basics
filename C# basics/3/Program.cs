using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer");
            var first=Console.ReadLine();

            Console.WriteLine("Enter second integer");
            var second=Console.ReadLine();

            var temp = second;
            second = first;
            first = temp;

            Console.WriteLine($"first number is {first}");
            Console.WriteLine($"second number is {second}");

        }
    }
}
