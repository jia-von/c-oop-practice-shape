using System;
using C_OOP_Practice_Shape.Shapes;

namespace C_OOP_Practice_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw drawing = new Draw(new Circle(3, Shape.Colour.Blue));
            drawing.AddShape(new Triangle(3, 5, Shape.Colour.Green));
            drawing.AddShape(new Rectangle(3, 5, Shape.Colour.Red));
            drawing.AddShape(new Triangle(3, 5, Shape.Colour.Red));
            drawing.AddShape(new Rectangle(3, 5, Shape.Colour.Green));
            drawing.AddShape(new Circle(5, Shape.Colour.Red));
            drawing.AddShape(new Circle(5, Shape.Colour.Green));
            Console.WriteLine(drawing.ToString());
            
        }
    }
}
