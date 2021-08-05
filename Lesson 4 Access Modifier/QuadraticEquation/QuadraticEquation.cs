using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        public double getA()
        {
            return this.a;
        }

        public void setA(double a)
        {
            this.a = a;
        }

        public double getB()
        {
            return this.b;
        }

        public void setB(double b)
        {
            this.b = b;
        }

        public double getC()
        {
            return this.c;
        }

        public void setC(double c)
        {
            this.c = c;
        }


        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetDiscriminant(double a, double b, double c) {
            var delta = b*b - 4*a*c;
            return delta;
        }

        public double GetRoot1(double a, double b, double delta)
        {
            var r1 = (-b + Math.Sqrt(delta)) / (2*a);
            return r1;
        }

        public double GetRoot2(double a, double b, double delta)
        {
            var r2 = (-b - Math.Sqrt(delta)) / (2*a);
            return r2;
        }
    }
}