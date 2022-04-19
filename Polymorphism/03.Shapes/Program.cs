using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(3,4);
            Shape circle = new Circle(6);
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.Draw());
        }
    }
}
