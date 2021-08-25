using System;

namespace Shape
{
    public class Circle: Shape
    {
        private double radius = 1.0;

        public double getRadius()
        {
            return this.radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }


        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, String color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public double GetPerimeter()
        {
            return Math.PI * (2 * radius);
        }

        public override String ToString()
        {
            return "A Circle with radius " + getRadius() + " with is a subclass of " + base.ToString();
        }

    }
}