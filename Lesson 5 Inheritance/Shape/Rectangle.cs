using System;

namespace Shape
{
    public class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public double getWidth()
        {
            return this.width;
        }

        public virtual void setWidth(double width)
        {
            this.width = width;
        }

        public double getLength()
        {
            return this.length;
        }

        public virtual void setLength(double length)
        {
            this.length = length;
        }


        public Rectangle()
        {

        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled): base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double getArea()
        {
            return width * length;
        }

        public double getPerimeter()
        {
            return (width + length) * 2;
        }

        public override String ToString()

        {

            return "A Rectangle with width="

                    + getWidth()

                    + " and length="

                    + getLength()

                    + ", which is a subclass of "

                    + base.ToString();

        }
    }
}