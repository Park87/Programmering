using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Database
    {

        private List<Shape3D> shapes;

        public void Adshape(Shape3D form)
        {
            shapes.Add(form);
        }


        public Database()
        {
            shapes = new List<Shape3D>();
            shapes.Add(new Sphere(4.0));
            shapes.Add(new Cube(3.0));
            shapes.Add(new Cylinder(4.0, 6.0));
        }

        public void Print()
        {
            foreach(Shape3D värden in shapes)
            {
                värden.Print();
            }
        }
    }
}
