using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Enter quality rounds");
            int n = Console.Read();
            Round[] round = new Round[n];

            for (int i = 0; i < n; i++)
            {
                round[i].radius = rand.Next();
            }

            for (int i = 0; i < n; i++)
            {
                round[i].Print();
            }

            Console.ReadLine();
        }

        class Round
        {
            public double radius;
                        
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

            public void Print()
            {
                Console.WriteLine("Square = " + Square() + "  Length = " + Length());
            }

        }
        class Cylinder : Round
        {
            double height;

            public double Volume()
            {
                double volume = Square() * height;
                return volume;
            }

        }
    }
}
