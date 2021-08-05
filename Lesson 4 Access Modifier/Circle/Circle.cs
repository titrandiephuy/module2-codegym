using System;

namespace Circle
{
    class Circle
    {
        private double radius = 1;
        private string color = "red";

        public double getRadius()
        {
            return this.radius;
        }

        public void setRadius(double radius)
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
        {}
        public Circle(double radius){
            this.radius = radius;
        }

    }
}