using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Cylinder: Shape3D
    {

        private double radius;
        private double height;

        public Cylinder(double r, double h)
        {
            height = h;
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
            Console.WriteLine("Cylinder");
            Console.WriteLine("Radius" + radius);
            Console.WriteLine("Height" + height);
            Console.WriteLine("Area" + GetArea());
            Console.WriteLine("Volume" + GetVolume());
        }
    }
}
