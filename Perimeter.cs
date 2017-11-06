using System;

namespace Geometry.Calculator
{
    public class Perimeter
    {
        public Perimeter()
        {
            double Triangle(double varOne, double varTwo, double varThree)
            {
                return (varOne + varTwo + varThree);
            }

            double Rectangle(double varOne, double varTwo)
            {
                return ((varOne * 2) + (varTwo * 2));
            }

            double Square(double varOne)
            {
                return (varOne * 4);
            }

            double Circle(double varTwo)
            {
                return (Math.PI * varTwo);
            }
        }
    }
}