using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    class Rectangle : Shape //Create a “Rectangle” class that inherits from Shape with the following properties
    {
        public int Perimeter {
            get => (Length * 2) + (Width * 2);
        } //Perimeter (public getter only)
        public override double Area 
        { 
            get => Length * Width;
        } //Area (public getter only)
        private int Length { get; set; } //Length (private getter and setter)
        private int Width { get; set; } //Width (private getter and setter)
        public override Colour ShapeColour { get; }

        //Create constructors for all three shapes that require their private properties as arguments.
        public Rectangle(int length, int width, Colour colour)
        {
            Length = length;
            Width = width;
            ShapeColour = colour;
        }

        //public override string ToString()
        //{
        //    return $"The perimeter of the Rectangle is {Perimeter}. ";
        //}
    }
}
