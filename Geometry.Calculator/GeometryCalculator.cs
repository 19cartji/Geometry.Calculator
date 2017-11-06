using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator
{
    class GeometryCalculator
    {
        static void Main()
        {
            string parOne;
            double varOne;

            string parTwo;
            double varTwo;

            bool parThree = false;
            double varThree = 1;

            while (true)
            {
                //The user decides the shape
                Console.Write("Enter \"triangle\", \"rectangle\", \"square\" or \"circle\", or type \"quit\" to leave: ");

                var entry = Console.ReadLine();
                if (entry.ToLower() == "triangle")
                {
                    parOne = "base";
                    parTwo = "height";
                    parThree = true;
                }
                else if (entry.ToLower() == "rectangle")
                {
                    parOne = "base";
                    parTwo = "height";
                }
                else if (entry.ToLower() == "square")
                {
                    parOne = "side";
                    parTwo = "side again";
                }
                else if (entry.ToLower() == "circle")
                {
                    parOne = "radius";
                    parTwo = "diameter";
                }
                else if (entry.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    Console.Write("Sorry, it seems this shape is not implemented yet. But you can donate CAD$49.99 to help the program grow!\n");
                    continue;
                }

                //The user enters the first variable
                while (true)
                {
                    Console.Write("Enter the " + parOne + ": ");

                    entry = Console.ReadLine();
                    try
                    {
                        varOne = double.Parse(entry);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.Write("Chap, you need to enter a number!\n");
                        continue;
                    }
                }

                //The user enters the second variable
                while (true)
                {
                    Console.Write("Enter the " + parTwo + ": ");

                    entry = Console.ReadLine();
                    try
                    {
                        varTwo = double.Parse(entry);

                        //If the diamater isn't the double of the radius, there's a problem :P
                        if (parOne == "radius" && varTwo != (varOne * 2))
                        {
                            Console.Write("Mate...the diameter is twice the radius.\n");
                            continue;
                        }

                        break;

                    }
                    catch (FormatException)
                    {
                        Console.Write("Chap, you need to enter a number!\n");
                        continue;
                    }
                }

                //If the user selected a triangle, we need the third side
                if (parThree == true)
                {
                    while (true)
                    {
                        Console.Write("Enter the third side: ");

                        entry = Console.ReadLine();
                        try
                        {
                            varThree = double.Parse(entry);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.Write("Chap, you need to enter a number!\n");
                            continue;
                        }
                    }

                }

                //The user selects what operation to perform
                while (true)
                {
                    Console.Write("Enter \"perimeter\" or \"area\": ");
                    entry = Console.ReadLine();

                    if (entry.ToLower() == "perimeter")
                    {
                        if (parThree == true)
                        {
                            Console.Write(Perimeter.Triangle(varOne, varTwo, varThree));
                        }
                        else if (parOne == "base")
                        {
                            Console.Write(Perimeter.Rectangle(varOne, varTwo));
                        }
                        else if (parOne == "side")
                        {
                            Console.Write(Perimeter.Square(varOne));
                        }
                        else
                        {
                            Console.Write(Perimeter.Circle(varOne));
                        }
                        Console.Write("\n");
                        break;
                    }
                    else if (entry.ToLower() == "area")
                    {
                        if (parThree == true)
                        {
                            Console.Write(Area.Triangle(varOne, varTwo));
                        }
                        else if (parOne == "base")
                        {
                            Console.Write(Area.Rectangle(varOne, varTwo));
                        }
                        else if (parOne == "side")
                        {
                            Console.Write(Area.Square(varOne));
                        }
                        else
                        {
                            Console.Write(Area.Circle(varOne));
                        }
                        Console.Write("\n");
                        break;
                    }
                    else
                    {
                        Console.Write("This isn't a professional calculator. Perimeter or area, take your pick.\n");
                        continue;
                    }
                }
            }
        }

        private class Perimeter
        {
            internal static string Circle(double varOne)
            {
                throw new NotImplementedException();
            }

            internal static string Rectangle(double varOne, double varTwo)
            {
                throw new NotImplementedException();
            }

            internal static string Square(double varOne)
            {
                throw new NotImplementedException();
            }

            internal static string Triangle(double varOne, double varTwo, double varThree)
            {
                throw new NotImplementedException();
            }
        }

        private class Area
        {
            internal static string Circle(double varOne)
            {
                throw new NotImplementedException();
            }

            internal static string Rectangle(double varOne, double varTwo)
            {
                throw new NotImplementedException();
            }

            internal static string Square(double varOne)
            {
                throw new NotImplementedException();
            }

            internal static string Triangle(double varOne, double varTwo)
            {
                throw new NotImplementedException();
            }
        }
    }
}