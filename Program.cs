using System;

namespace C_OOP_Practice_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw drawing = new Draw(new Shapes.Circle(3));
            Console.WriteLine(drawing.ToString());
            
        }
    }
}
