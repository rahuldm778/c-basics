// using System;

// namespace _1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }
//C# program to demonstrate the null reference exception.

using System;

class ExceptionDemo
{
    void PrintHello()
    {
        Console.WriteLine("Hello World");
    }
    static void Main()
    {
        try
        {
            ExceptionDemo E = new ExceptionDemo();

            E = null;
            E.PrintHello();
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

