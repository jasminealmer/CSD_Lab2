using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_CSD_JasmineAlmer
{
    class Circle : Shape
    {
        public Circle(double x, double y, double length, double instancePoint)
        {
            X = x;
            Y = y;
            Length = length;
            InstancePoint = instancePoint;
            Area = CalculateArea();
            TypePoint = SetTypePoint();
            ShapeScore = CalculateShapeScore();
        }

        //Method that calculates the area of a cirlce
        private double CalculateArea()
        {
            double radius = Length / (2 * 3.14);
            double area = radius * radius * 3.14;
            return area;
        }

        //Method that sets the TypePoint of a circle
        private int SetTypePoint()
        {
            return 2;
        }

        //Method that calculates the ShapeScore of a cirlce
        private double CalculateShapeScore()
        {
            return TypePoint * InstancePoint / Area;
        }
    }
}
