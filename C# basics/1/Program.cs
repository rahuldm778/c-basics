using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give input for numbers.");
            //Console.WriteLine("1st Number");
            double first;

            //Console.WriteLine("2nd Number");
            double sec;

            //Console.WriteLine("3rd Number");
            double third ;

            //Console.WriteLine("4th Number");
            double fourth ;

            Operations(out first, out sec, out third, out fourth);
        }

        public static void Operations(out double first, out double sec, out double third, out double fourth){
            Console.WriteLine("1st Number");
            first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2nd Number");
            sec = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3rd Number");
            third = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("4th Number");
            fourth = Convert.ToDouble(Console.ReadLine());

            var sum = first + sec + third + fourth;
            var subration = first - sec - third - fourth;
            var multiplication = first * sec * third * fourth;

            Console.WriteLine($"Addition of numbers {sum}");
            Console.WriteLine($"Subration of numbers {subration}");
            Console.WriteLine($"Addition of numbers {multiplication}");

        }
    }
}
