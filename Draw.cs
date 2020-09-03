using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Practice_Shape
{
    class Draw
    {
        public double SpaceCovered { get; } //SpaceCovered (public getter only), which will get the total area of all shapes drawn.
        public double LinesDrawn { get; } //LinesDrawn (public getter only), which will get the total perimeter/circumference of all shapes drawn.
        private List<Shapes.Shape> Shapes { get; set; }// Shapes (private getter and setter), polymorphic list

        public Draw(Shapes.Shape shape)//Draw(Shape), which will accept a polymorphic argument and add that to the Shapes list.
        {
            Shapes.Add(shape);
        }

        //A ToString() override, which will output “A drawing consisting of X shapes.” where X is the number of shapes in the polymorphic list.
        public override string ToString()
        {
            return $"A drawing consisting of {Shapes.Count} shapes";
        }
    }

}
