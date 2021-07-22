using System;

namespace Interphase
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1= new Shape();

            Console.WriteLine("Input value as circles radius and cubes edge");

            shape1.x = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine($"Area of circles for given radius is {shape1.CircleArea()}");
            Console.WriteLine($"Total Surface Area of cube for given radius is {shape1.CubeArea()}");
        }
    }
}
