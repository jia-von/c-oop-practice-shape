using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    class Circle : Shape //Create a “Circle” class that inherits from Shape with the following properties:
    {
        public double Circumference {
            get => 2 * Math.PI * Radius;
        } //Circumference (public getter only)

        public override double  Area 
        { 
            get => Math.PI * Math.Pow(Radius, 2);
        } //Area (public getter only)
        private int Radius { get; set; } //Radius (private getter and setter)
        private Colour ShapeColour { get; set; }

        //Create constructors for all three shapes that require their private properties as arguments.
        public Circle(int radius, Colour colour)
        {
            Radius = radius;
            ShapeColour = colour;
        }
        public override string ToString()
        {
            return $"The circumference of a circle is {Circumference}. ";
        }
    }
}
