using System;

namespace C_OOP_Practice_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw drawing = new Draw(new Shapes.Circle(3, Shapes.Shape.Colour.Blue));
            drawing.AddShape(new Shapes.Triangle(3, 5, Shapes.Shape.Colour.Green));
            drawing.AddShape(new Shapes.Rectangle(3, 5, Shapes.Shape.Colour.Red));
            drawing.AddShape(new Shapes.Triangle(3, 5, Shapes.Shape.Colour.Red));
            drawing.AddShape(new Shapes.Rectangle(3, 5, Shapes.Shape.Colour.Green));
            Console.WriteLine(drawing.ToString());
            
        }
    }
}
