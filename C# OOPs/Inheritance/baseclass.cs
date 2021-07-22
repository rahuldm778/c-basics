using System;

namespace Inheritance
{
    abstract class Base
    {
        public double x {get;set;}
        public double y {get;set;}

        public double name {get;set;}

        public abstract double area();
    }

    class Triangle:Base{
        public override double area(){
            return x*y/2.0;
        }
    }

    class Square:Base{
        public override double area(){
            return x*x;
        }
    }

    class Rectangle:Base{
        public override double area(){
            return x*y;
        }
    }

    class Cube:Base{
        public override double area(){
            return x*x*6;
        }
    }
}