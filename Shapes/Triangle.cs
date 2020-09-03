using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    class Triangle : Shape //Create a “Triangle” class that inherits from Shape with the following properties:
    {
        public double Perimeter { get; } //Perimeter (public getter only)
        //public double Area { get; } Area (public getter only)
        private int Length { get; set; } //Length (private getter and setter)
        private int Width { get; set; } //Width (private getter and setter)

        //Create constructors for all three shapes that require their private properties as arguments.
        public Triangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
    }
}
