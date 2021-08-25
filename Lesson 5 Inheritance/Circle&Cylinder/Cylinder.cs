using System;

namespace Circle_Cylinder

{
    class Cylinder : Circle
    {
        private double height = 1;

        public double getHeight()
        {
            return this.height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public Cylinder()
        {

        }

        public Cylinder(double height, double radius, string color) : base(radius, color)
        {
            this.height = height;
        }

        public double GetVolume()
        {
            return Math.PI * (radius * radius) * height;
        }

        public override string ToString()
        {
            return "A Cylinder with radius " + getRadius() + " and color " + getColor() + " has volume " + GetVolume();
        }



    }
}