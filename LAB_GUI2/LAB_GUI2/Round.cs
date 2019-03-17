using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_GUI2
{
    class Round
    {
        public double radius;

        public Round()
        {
        }

        public Round(double radius)
        {
           Radius = radius;
        }

        public double Radius { get => radius; set => radius = value >= 0 ? value : 0; }

        public double Square()
        {
            double square = Math.Sqrt(radius) * Math.Round(Math.PI, 2);
            return square;
        }
        public double Length()
        {
            double length = 2 * radius * Math.Round(Math.PI, 2);
            return length;
        }

        public override string ToString()
        {
            return "\nCircle radius = " + this.Radius + "\nSquare = " + this.Square() + "\nLength = " + this.Length();
        }
    }
}
