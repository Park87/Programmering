using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Cube: Shape3D
    {

        private double length;

        public Cube(double l)
        {
            length = l;
        }


        public double GetArea()
        {
            return length * length * 6;
        }

        public double GetVolume()
        {
            return length * length * length;
        }

        public void Print()
        {
            Console.WriteLine("Cube");
            Console.WriteLine("Length" + length);
            Console.WriteLine("Area" + GetArea());
            Console.WriteLine("Volume" + GetVolume());
        }
    }
}
