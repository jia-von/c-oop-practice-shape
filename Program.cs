using System;

namespace C_OOP_Practice_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw drawing = new Draw(new Shapes.Circle(3));
            drawing.AddShape(new Shapes.Triangle(3, 5));
            drawing.AddShape(new Shapes.Rectangle(3, 5));
            drawing.AddShape(new Shapes.Triangle(3, 5));
            drawing.AddShape(new Shapes.Rectangle(3, 5));
            Console.WriteLine(drawing.ToString());
            
        }
    }
}
