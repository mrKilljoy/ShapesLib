using System;
using System.Linq;

namespace ShapesLib
{
    public class Triangle : IShape
    {
        private readonly double[] _sides = new double[3];

        public Triangle(double a, double b, double c)
        {
            _sides[0] = a;
            _sides[1] = b;
            _sides[2] = c;

            if (!IsValid())
                throw new ArgumentException("the triangle is not valid");
        }

        public double SideA => _sides[0];

        public double SideB => _sides[1];

        public double SideC => _sides[2];

        public double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        private bool IsValid()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                return false;

            return SideA + SideB > SideC &&
                SideA + SideC > SideB &&
                SideB + SideC > SideA;
        }

        private bool IsIsosceles()
        {
            return SideA == SideB ||
                SideA == SideC ||
                SideB == SideC;
        }

        public bool IsRight()
        {
            if (IsIsosceles())
                return false;

            double hyp = _sides.Max();
            int hypIndex = Array.IndexOf(_sides, hyp);
            var legs = _sides.Except(new[] { hyp });
            return hyp * hyp == legs.Select(c => c * c).Sum();
        }
    }
}
