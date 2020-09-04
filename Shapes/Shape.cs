using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape.Shapes
{
    public abstract class Shape
    {//Create a “Shape” class with an Area property (public getter only) that must be overwritten by derived classes.
        public abstract double Area { get; }

    }
}
