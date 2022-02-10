using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    interface Shape3D
    {
        double GetArea();

        double GetVolume();

        public abstract void Print();
    }
}
