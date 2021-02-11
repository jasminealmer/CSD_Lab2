using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_CSD_JasmineAlmer
{
    class PaperSystem
    {
        private double hitShapeScores = 0;
        private double missedShapeScores = 0;

        //Method that calculates the PointScore
        public double PointScore(double[] coordinates, List<Shape> allShapes)
        {
            HitOrMiss(coordinates, allShapes);
            double result = (hitShapeScores) - (0.25 * missedShapeScores);

            return Math.Ceiling(result);
        }

        //Method that checks hit or miss for each square and circle
        private void HitOrMiss(double[] coordinates, List<Shape> allShapes) 
        {
            double x = coordinates[0];
            double y = coordinates[1];

            foreach (var s in allShapes)
            {
                if (s.TypePoint == 1)
                {
                    //calculates the specific leftbottom point and topright point for each square
                    double eachSide = s.Length / 4;
                    double leftBottomX = (s.X - eachSide) / 2;
                    double leftBottomY = (s.Y - eachSide) / 2;
                    double rightTopX = (s.X + eachSide) / 2;
                    double rightTopY = (s.Y + eachSide) / 2;

                    //calculates if the input (x,y) is inside or outside each square and adds the ShapeScore accordingly via hit/miss variables
                    if ((x > leftBottomX && x < rightTopX && y > leftBottomY && y < rightTopY))
                    {
                        hitShapeScores += s.ShapeScore;
                    }
                    else
                    {
                        missedShapeScores += s.ShapeScore;
                    }
                }
                else
                {
                    double radius = s.Length / (2 * 3.14);

                    //calculates if input point (x,y) is within each circle and adds the ShapeScore accordingly via hit/miss variables
                    if (Math.Pow((x - s.X), 2) + Math.Pow((y - s.Y), 2) < Math.Pow(radius, 2))
                    {
                        hitShapeScores += s.ShapeScore;
                    }
                    else
                    {
                        missedShapeScores += s.ShapeScore;
                    }
                }
                
            }

        }
    }
}
