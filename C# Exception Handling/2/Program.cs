// using System;

// namespace _2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

class TestUnboxing
{
    static void Main()
    {
        int num = 123;
        object obj = num; 
        try
        {
            int j = (short)obj; 
            System.Console.WriteLine("Unboxing");
        }
        catch (System.InvalidCastException e)
        {
            System.Console.WriteLine("{0} Error: Incorrect unboxing", e.Message);
        }
        //System.Console.Read();
    }
}
