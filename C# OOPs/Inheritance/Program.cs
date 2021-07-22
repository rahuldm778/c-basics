using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give input for 1 for Triangle");
            Console.WriteLine("Give input for 2 for Square");
            Console.WriteLine("Give input for 3 for Reactangle");
            Console.WriteLine("Give input for 4 for Cube");

            int inp=int.Parse(Console.ReadLine());

            if(inp == 1){
                Triangle teriangle1= new Triangle();
                Console.WriteLine("Give input value for x");
                teriangle1.x=int.Parse(Console.ReadLine());

                Console.WriteLine("Give input value for y");
                teriangle1.y=int.Parse(Console.ReadLine());

                Console.WriteLine($"Area is {teriangle1.area()}");
            }else if(inp == 2){
                Square sq1= new Square();
                Console.WriteLine("Give input value for x");
                sq1.x=int.Parse(Console.ReadLine());

                // Console.WriteLine("Give input value for y");
                // sq1.y=int.Parse(Console.ReadLine());

                Console.WriteLine($"Area is {sq1.area()}");
            }else if(inp == 3){
                Rectangle rect1= new Rectangle();
                Console.WriteLine("Give input value for x");
                rect1.x=int.Parse(Console.ReadLine());

                Console.WriteLine("Give input value for y");
                rect1.y=int.Parse(Console.ReadLine());

                Console.WriteLine($"Area is {rect1.area()}");
            }else if(inp == 4){
                Cube cube1= new Cube();
                Console.WriteLine("Give input value for x");
                cube1.x=int.Parse(Console.ReadLine());

                // Console.WriteLine("Give input value for y");
                // cube1.y=int.Parse(Console.ReadLine());

                Console.WriteLine($"Total Surface Area is {cube1.area()}");
            }else{
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
