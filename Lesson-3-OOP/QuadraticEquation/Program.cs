using System;
using System.Diagnostics;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;
            Console.WriteLine("Enter a: ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            double c = Double.Parse(Console.ReadLine());

            QuadraticEquation qd = new QuadraticEquation(a, b, c);

            double d = qd.GetDiscriminant();
            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root Root2= {0}\n", x2);
            }
            else if (d > 0)
            {
                Console.WriteLine("Both roots are real and diff-2\n");
                x1 = qd.GetRoot1();
                x2 = qd.GetRoot2();
                Console.WriteLine("First root: {0}", x1);
                Console.WriteLine("Second root: {0}", x2);
            }
            else
            {
                Console.WriteLine("Root are imeainary\n No Solution");
            }
            Console.ReadLine();

        }


        public class QuadraticEquation
        {
            private double a;
            private double b;
            private double c;
            public QuadraticEquation(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double GetA
            {
                get
                {
                    return a;
                }
            }
            public double getB
            {
                get
                {
                    return b;
                }
            }
            public double getC
            {
                get
                {
                    return c;
                }
            }

            public double GetDiscriminant()
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                return delta;
            }

            public double GetRoot1()
            {
                double r1 = (-b + Math.Sqrt(GetDiscriminant())) / 2 * a;
                return r1;
            }

            public double GetRoot2()
            {
                double r2 = (-b - Math.Sqrt(GetDiscriminant())) / 2 * a;
                return r2;
            }
        }
    }
}

