# C# Object-orientated Programming with Shape Creation

The goal of this assignment is help me familiarized with inheritance, polymorphism, encapsulation, and abstration class.

## Installation

```bash
$ git clone https://github.com/jia-von/c-oop-practice-shape.git
$ cd c-oop-practice-shape
$ start devenv C-OOP-Practice-Shape.sln

`````

## Approach

- A public abstract class, `Shape.cs` with properties 'Area', `ShapeColour`, and `Perimeter`. These properties are abstract properties with only public getter.
- Three classes, `Circle.cs`, `Triangle.cs`, and `Rectangle.cs` were created and these classes inehrits from `Shape.cs`.These three classes has properties that will help calculate area and perimeter depending on weather user to `Draw()` the type of **Shape**: **Circle**, **Triangle**, or **Rectangle**.
- A `Drawing.cs` class was created in the root assembly. This class has:
  - `SpaceCovered` property, which will get the total area of all shapes drawn.
  - `LinesDrawn` property, which will get the total perimeter/circumference of all shapes drawn.
  - `Shapes` property, that is a polymorphic list.
  - `Draw(Shape)` method, which will accept a polymorphic argument and add that to the `Shapes` list.
  - A `ToString()` method override, which will output “A drawing consisting of X shapes that is Y % red, Y % green, and Y % blue.” where X is the number of shapes in the polymorphic list and Y is the percentage of colour covered in X.

## Usage

The `Program.cs` is pre-populated with code as shown below. Execute Debugging to run the program. 

![Program](/References/Program.PNG)

## Result within console

![Console](/References/Console.PNG)