using System;

namespace Geometry.Calculator
{
    public class Area
    {
        public Area()
        {
            double Triangle(double varOne, double varTwo)
            {
                return ((varOne * varTwo) / 2);
            }

            double Rectangle(double varOne, double varTwo)
            {
                return (varOne * varTwo);
            }

            double Square(double varOne)
            {
                return (varOne * varOne);
            }

            double Circle(double varOne)
            {
                return (Math.PI * (varOne * varOne));
            }
        }
    }
}