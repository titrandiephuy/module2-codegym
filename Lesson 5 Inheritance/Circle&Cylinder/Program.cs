using System;

namespace Circle_Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle circle = new Circle();
            // Console.WriteLine(circle);
            // circle = new Circle(10, "violet");
            // Console.WriteLine(circle);
            Cylinder cylinder = new Cylinder();
            Console.WriteLine(cylinder);
            cylinder = new Cylinder(10, 5, "red");
            Console.WriteLine(cylinder);
        }
    }
}
