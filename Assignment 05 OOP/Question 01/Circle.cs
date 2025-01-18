using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP
{
    internal class Circle : ICircle

    {
        public double Radies { get; set ; }

        public double Area  => 3.14 * Radies * Radies ;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Area Is: {Area}");
        }
    }
}
