using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square(20,"red");
        Rectangle rectangle = new Rectangle(20,30,"green");
        Circle circle = new Circle(15,"black");
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}