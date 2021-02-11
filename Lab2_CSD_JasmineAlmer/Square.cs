using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_CSD_JasmineAlmer
{
    class Square : Shape
    {
        public Square(double x, double y, double length, double instancePoint)
        {
            X = x;
            Y = y;
            Length = length;
            InstancePoint = instancePoint;
            Area = CalculateArea();
            TypePoint = SetTypePoint();
            ShapeScore = CalculateShapeScore();
        }

        //Method that calculates the area of a square
        private double CalculateArea()
        {
            double eachSide = Length / 4;
            double area = eachSide * eachSide;
            return area;
        }

        //Method that sets a TypePoint of a square
        private int SetTypePoint()
        {
            return 1;
        }

        //Method that calculates the ShapeScore of a square
        private double CalculateShapeScore()
        {
            return TypePoint * InstancePoint / Area;
        }
    }


}

