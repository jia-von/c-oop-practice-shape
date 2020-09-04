using System;
using C_OOP_Practice_Shape.Shapes;

namespace C_OOP_Practice_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing drawing = new Drawing(new Circle(3, Shape.Colour.Blue));
            drawing.Draw(new Triangle(3, 5, Shape.Colour.Green));
            drawing.Draw(new Rectangle(3, 5, Shape.Colour.Red));
            drawing.Draw(new Triangle(3, 5, Shape.Colour.Red));
            drawing.Draw(new Rectangle(3, 5, Shape.Colour.Green));
            drawing.Draw(new Circle(5, Shape.Colour.Red));
            drawing.Draw(new Circle(5, Shape.Colour.Green));
            Console.WriteLine(drawing.ToString());
            
        }
    }
}
