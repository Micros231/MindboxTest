using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindboxTest
{
    public class Triangle : Figure
    {
        public float SideA => _sideA;
        public float SideB => _sideB;
        public float SideC => _sideC;

        private readonly float _sideA, _sideB, _sideC;

        public Triangle(float sideA, float sideB, float sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public bool IsRectangular()
        {
            var a = MathF.Pow(_sideA, 2);
            var b = MathF.Pow(_sideB, 2);
            var c = MathF.Pow(_sideC, 2);
            List<float> sides = new List<float>() { a, b, c };
            var maxSide = sides.Max();
            float g = 0;
            if (maxSide == a)
                g = b + c;
            else if (maxSide == b)
                g = a + c;
            else if (maxSide == c)
                g = a + b;
            if (maxSide == g)
            {
                return true;
            }
            return false;
        }
        public override float Square()
        {
            var p = (_sideA + _sideB + _sideC) / 2;
            var square = p * (p - _sideA) * (p - _sideB) * (p - _sideC);
            square = MathF.Sqrt(square);
            return square;
        }

    }
}
