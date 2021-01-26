using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxTest
{
    public class Circle : Figure
    {
        public float Radius => _radius;

        private readonly float _radius;
        public Circle(float radius)
        {
            _radius = radius;
        }

        public override float Square()
        {
            float square = MathF.PI * MathF.Pow(_radius, 2);
            return square;

        }
    }
}
