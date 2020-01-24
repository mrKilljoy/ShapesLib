using ShapesLib;
using System;

namespace ShapesCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            var a1 = circle.GetArea();
            Console.WriteLine("Circle area is " + a1);

            IShape triangle = new Triangle(16, 12, 20);
            var a2 = triangle.GetArea();
            Console.WriteLine("Triangle area is " + a2);

            bool rightFlag = ((Triangle)triangle).IsRight();
            Console.WriteLine("Is triangle right? " + rightFlag);

            Console.ReadLine();
        }
    }
}
