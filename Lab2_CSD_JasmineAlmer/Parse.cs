using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_CSD_JasmineAlmer
{
    public class Parse
    {
        private readonly List<Shape> Shapes = new List<Shape>();

        //Method that creates coordinates from the input string
        public double[] CreateCoordinates(string coordinates)
        {
            if (coordinates.Contains(" "))
            {
                coordinates = coordinates.Replace(" ", "");
            }

            var separateCoordinates = coordinates.Split(",");
            double c1 = Convert.ToDouble(separateCoordinates[0]);
            double c2 = Convert.ToDouble(separateCoordinates[1]);
            double[] coordinatesArray = new double[2];
            coordinatesArray[0] = c1;
            coordinatesArray[1] = c2;

            return coordinatesArray;
        }

        //Method that creates the shapes circle or square from the input string
        public List<Shape> CreateShapes(string shapes)
        {
            if (shapes.Contains(" "))
            {
                shapes = shapes.Replace(" ", "");
            }

            try
            {
                string[] items = shapes.Split(";");
                string[] headings = items[0].ToLower().Split(",");

                int shapeIndex = Array.IndexOf(headings, "shape");
                int xIndex = Array.IndexOf(headings, "x");
                int yIndex = Array.IndexOf(headings, "y");
                int lengthIndex = Array.IndexOf(headings, "length");
                int pointIndex = Array.IndexOf(headings, "points");

                //for every item: parse and add shape accordingly
                for (int i = 1; i < items.Length - 1; i++)
                {
                    var splittedItems = items[i].Split(",");

                    string shapeType = splittedItems[shapeIndex].ToLower();
                    double x = double.Parse(splittedItems[xIndex]);
                    double y = double.Parse(splittedItems[yIndex]);
                    double length = double.Parse(splittedItems[lengthIndex]);
                    double instancePoint = double.Parse(splittedItems[pointIndex]);

                    if (shapeType == "circle")
                    {
                        Circle circle = new Circle(x, y, length, instancePoint);
                        Shapes.Add(circle);
                    }
                    else if (shapeType == "square")
                    {
                        Square square = new Square(x, y, length, instancePoint);
                        Shapes.Add(square);
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Wrong input format in either the first or second line argument!");
            }   
            catch (ArgumentException)
            {
                Console.WriteLine("You put in the wrong shape type somewhere, try again with Circle or Square.");
            }
            return Shapes;
        }
    }

}
