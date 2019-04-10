using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Vector
    {
        private double x;
        private double y;
        private double z;

        public double X { get => x; set => x = value >= 0 ? value : 0; }
        public double Y { get => y; set => y = value >= 0 ? value : 0; }
        public double Z { get => z; set => z = value >= 0 ? value : 0; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Vector()
        {
        }

        public new string ToString()
        {
            return "X = " + X + ";" + "Y = " + Y + ";" + "Z = " + Z;
        }

        public double GetLength()
        {
            double length = 0;
            length = Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
            return Math.Round(length, 2);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        
        public static double operator %(Vector a, Vector b)
        {
            double res = 0;
            res = a.X * b.X + a.Y * b.Y + a.Z * b.Z;
            return res;
        }

        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
        }      
    }
}
