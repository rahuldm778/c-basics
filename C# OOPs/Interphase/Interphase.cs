using System;

namespace Interphase
{
    interface ICircle
    {
        double CircleArea();
    }
    interface ICube
    {
        double CubeArea();
    }

    class Shape : ICircle , ICube{
        public double x{get;set;}
        public double CircleArea(){
            return 2*3.14159*x;
        }
        public double CubeArea(){
            return x*x*6;
        }
    }
}