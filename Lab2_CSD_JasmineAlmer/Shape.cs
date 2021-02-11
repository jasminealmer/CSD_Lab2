using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_CSD_JasmineAlmer
{
    public abstract class Shape
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }
        public double Length { get; protected set; }
        public double Area { get; protected set; }
        public int TypePoint { get; protected set; }
        public double InstancePoint { get; protected set; }
        public double ShapeScore { get; protected set; }

    }
}

