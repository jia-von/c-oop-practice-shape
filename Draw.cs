using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C_OOP_Practice_Shape.Shapes;
namespace C_OOP_Practice_Shape
{
    class Draw
    {
        public double SpaceCovered 
        { 
            get => ListShapes.Sum(x => x.Area);
        } //SpaceCovered (public getter only), which will get the total area of all shapes drawn.
        public double LinesDrawn { get; } //LinesDrawn (public getter only), which will get the total perimeter/circumference of all shapes drawn.

        private List<Shape> ListShapes { get; set; }// ListShapes (private getter and setter), polymorphic list

        public Draw()
        {
            ListShapes = new List<Shape>();
        }
        public Draw(Shape shape)    //Draw(Shape), which will accept a polymorphic argument and add that to the ListShapes list.
        {
            ListShapes = new List<Shape>();
            AddShape(shape);
        }

        public void AddShape(Shape shape)
        {
            ListShapes.Add(shape);

        }

        //A ToString() override, which will output “A drawing consisting of X shapes.” where X is the number of shapes in the polymorphic list.
        public override string ToString()
        {
            return $"A drawing consisting of {ListShapes.Count()} shapes that is {Math.Round((ListShapes.FindAll(x => x.ShapeColour == Shape.Colour.Red).Sum(y => y.Area)/SpaceCovered)*100, 2)} % red, {Math.Round((ListShapes.FindAll(x => x.ShapeColour == Shape.Colour.Green).Sum(y => y.Area) / SpaceCovered)*100, 2)} % green and {Math.Round((ListShapes.FindAll(x => x.ShapeColour == Shape.Colour.Blue).Sum(y => y.Area) / SpaceCovered)*100, 2)} % blue. Total perimeter drawn";
        }

    }

}
