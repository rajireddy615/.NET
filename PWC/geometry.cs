using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWC

{
    internal class Shapes
    {
        static void Main()
        {
            Circle circle = new Circle(5.0f);
            Console.WriteLine("Radius : " + circle.getRadius());
            Console.WriteLine("Area : " + circle.CalculateCircleArea());
            Console.WriteLine("Circumference : " + circle.CalculateCircumference());
        }
    }
}
