using System;

namespace ShapesLib
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            if (!IsValid(radius))
                throw new ArgumentException(nameof(radius));

            Radius = radius;
        }

        public double Radius { get; private set; }

        public double GetArea() => Math.PI * Math.Pow(Radius, 2);

        private bool IsValid(double radius) => radius > 0;
    }
}
