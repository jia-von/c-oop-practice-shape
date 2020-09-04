using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    class Circle : Shape //Create a “Circle” class that inherits from Shape with the following properties:
    {
        public double Circumference //Why can't I use perimeter
        {
            get => 2 * Math.PI * Radius;
        } //Circumference (public getter only)

        public override double  Area 
        { 
            get => Math.PI * Math.Pow(Radius, 2);
        } //Area (public getter only)
        private int Radius { get; set; } //Radius (private getter and setter)
        public override Colour ShapeColour { get; }

        //Create constructors for all three shapes that require their private properties as arguments.
        public Circle(int radius, Colour colour)
        {
            Radius = radius;
            ShapeColour = colour;
        }
    }
}
