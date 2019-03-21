using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_GUI2
{
    class Cylinder : Round
    {
        private double height;

        public double Height { get => height; set => height = value >= 0 ? value : 0; }

        public Cylinder()
        {
        }

        public Cylinder(double height, double radius)
        {
            base.Radius = radius;
            Height = height;
        }       

        public double Volume()
        {
            double volume = Square() * height;
            return volume;
        }

        new public string ToString()
        {
            return "\nCircle radius = " + this.Radius + "\nHeight = " + this.Height +
                "\nVolume = " + this.Volume();
        }
    }
}
