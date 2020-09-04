using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    class Triangle : Shape //Create a “Triangle” class that inherits from Shape with the following properties:
    {
        public double Perimeter 
        {
            get 
            {
                return Length + Width + Math.Sqrt(Math.Pow(Length, 2)+Math.Pow(Width, 2));
            }
        } 
        
        //Perimeter (public getter only)
        public override double Area 
        { 
            get
            {
                return 0.5 * Length * Width;
            }
        } //Area (public getter only)
        private int Length { get; set; } //Length (private getter and setter)
        private int Width { get; set; } //Width (private getter and setter)

        //Create constructors for all three shapes that require their private properties as arguments.
        public Triangle()
        {
            Length = 0;
            Width = 0;
        }
        public Triangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public override string ToString()
        {
            return $"The perimeter of the triangle is {Perimeter}. ";
        }
    }
}
