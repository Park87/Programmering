using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Sphere: Shape3D
    {

        private double radius;

        public Sphere(double r)
        {
            radius = r;
        }

        public double GetArea()
        {
            return Math.PI * 4 * radius * radius;
        }

        public double GetVolume()
        {
            return Math.PI * 4 * radius * radius * radius / 3;
        }

        public void Print()
        {
            Console.WriteLine("Sphere");
            Console.WriteLine("Radius" + radius);
            Console.WriteLine("Area" + GetArea());
            Console.WriteLine("Volume" + GetVolume());

        }
    }
}
