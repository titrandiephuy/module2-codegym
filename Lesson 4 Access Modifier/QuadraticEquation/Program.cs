using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            QuadraticEquation qe = new QuadraticEquation(a, b, b);
            double delta = qe.GetDiscriminant(a, b, c);
            double x1 = 0.0;
            double x2 = 0.0;

            if( delta == 0)
            {
                x1 = - b / (2.0 * a );
                Console.Write("The equation has one root = {0}\n", x1);
            } else if ( delta > 0 ) {
                x1 = qe.GetRoot1(a, b, delta);
                x2 = qe.GetRoot2(a, b, delta);
                 Console.Write("The equation has two roots {0} and {1}\n", x1, x2);
            } else {
                Console.WriteLine("The equation has no roots");
            }
            Console.ReadKey();
        }
    }

}
