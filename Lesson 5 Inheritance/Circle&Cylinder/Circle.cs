using System;

namespace Circle_Cylinder
{
    class Circle
    {
        protected double radius = 1;
        protected string color = "red";

        public double getRadius()
        {
            return this.radius;
        }

        public virtual void setRadius(double radius)
        {
            this.radius = radius;
        }

        public string getColor()
        {
            return this.color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public Circle()
        {

        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double GetArea()
        {
            return Math.PI * (radius * radius);
        }

        public override string ToString()
        {
            return "A circle with radius " + getRadius() +" and color " + getColor() + " has area " + GetArea();
        }

    }
}