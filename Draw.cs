﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_OOP_Practice_Shape
{
    class Draw
    {
        public double SpaceCovered 
        { 
            get
            {
                return ListShapes.Sum(x => x.Area);
            }
        } //SpaceCovered (public getter only), which will get the total area of all shapes drawn.
        public double LinesDrawn { get; } //LinesDrawn (public getter only), which will get the total perimeter/circumference of all shapes drawn.

        private List<Shapes.Shape> ListShapes { get; set; }// ListShapes (private getter and setter), polymorphic list

        public Draw()
        {
            ListShapes = new List<Shapes.Shape>();
        }
        public Draw(Shapes.Shape shape)    //Draw(Shape), which will accept a polymorphic argument and add that to the ListShapes list.
        {
            ListShapes = new List<Shapes.Shape>();
            AddShape(shape);
        }

        public void AddShape(Shapes.Shape shape)
        {
            ListShapes.Add(shape);

        }

        //A ToString() override, which will output “A drawing consisting of X shapes.” where X is the number of shapes in the polymorphic list.
        public override string ToString()
        {
            return $"A drawing consisting of {ListShapes.Count()} shapes that is {Math.Round((ListShapes.FindAll(x => x.ShapeColour == Shapes.Shape.Colour.Red).Sum(y => y.Area)/SpaceCovered)*100, 2)} % red, {Math.Round((ListShapes.FindAll(x => x.ShapeColour == Shapes.Shape.Colour.Green).Sum(y => y.Area) / SpaceCovered)*100, 2)} % green and {Math.Round((ListShapes.FindAll(x => x.ShapeColour == Shapes.Shape.Colour.Blue).Sum(y => y.Area) / SpaceCovered)*100, 2)} % blue.";
        }

    }

}
