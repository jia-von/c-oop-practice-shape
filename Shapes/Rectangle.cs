using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    class Rectangle : Shape //Create a “Rectangle” class that inherits from Shape with the following properties
    {
        public double Perimeter { get; } //Perimeter (public getter only)
        //public double Area { get; } Area (public getter only)
        private int Length { get; set; } //Length (private getter and setter)
        private int Width { get; set; } //Width (private getter and setter)

        //Create constructors for all three shapes that require their private properties as arguments.
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

    }
}
