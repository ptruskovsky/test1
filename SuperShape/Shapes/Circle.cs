using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SuperShape.Interfaces;

namespace SuperShape.Shapes {
    public class Circle : IShape {

        private readonly int _radius;

        public Circle(int radius) 
        { 
            _radius = radius;
        }

        public double CalculateArea() 
            => Math.Round(Math.Pow(_radius, 2) * Math.PI, 2);

    }
}
