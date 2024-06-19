using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("blue", 10);
        shapes.Add(square);
        
        Rectangle rectangle = new Rectangle("purple", 6, 9);
        shapes.Add(rectangle);
        
        Circle circle = new Circle("red", 8);
        shapes.Add(circle);
        
        
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
        {
            
        }
    }
}