using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    class Circle : Shape //Create a “Circle” class that inherits from Shape with the following properties:
    {
        public double Circumference { get; } //Circumference (public getter only)

        //public double Area { get; } Area (public getter only)
        private int Radius { get; set; } //Radius (private getter and setter)

        //Create constructors for all three shapes that require their private properties as arguments.
        public Circle(int radius)
        {
            Radius = radius;
        }
    }
}
