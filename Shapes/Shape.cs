using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    public abstract class Shape
    {//Create a “Shape” class with an Area property (public getter only) that must be overwritten by derived classes.

        //Add a Colour enumeration to Shape - Red, Blue or Green, and require it in the constructors of each shape. In the ToString of drawing, output what percentage of the drawing is each colour, to the nearest hundredth of a percent. Example: “A drawing consisting of X shapes that is AA.AA% red, BB.BB% green and CC.CC% blue.
        public enum Colour
        {
            Red,
            Blue,
            Green
        }
        public abstract double Area { get; }
        public abstract Colour ShapeColour { get; }
        public abstract double Perimeter { get; }

    }
}
