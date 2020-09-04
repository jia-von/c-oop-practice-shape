using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    class Triangle : Shape //Create a “Triangle” class that inherits from Shape with the following properties:
    {
        public override double Perimeter 
        {
            get => Length + Width + Math.Sqrt(Math.Pow(Length, 2)+Math.Pow(Width, 2)); //Research and implement getter arrow notation on the Perimeter / Area methods.
        } 
        //Perimeter (public getter only)
        public override double Area 
        { 
            get => 0.5 * Length * Width;
        } //Area (public getter only)
        private int Length { get; set; } //Length (private getter and setter)
        private int Width { get; set; } //Width (private getter and setter)
        public override Colour ShapeColour { get; }

        //Create constructors for all three shapes that require their private properties as arguments.
        public Triangle(int length, int width, Colour colour)
        {
            Length = length;
            Width = width;
            ShapeColour = colour;
        }
    }
}
