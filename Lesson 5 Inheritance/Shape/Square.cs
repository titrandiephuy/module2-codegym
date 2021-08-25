using System;

namespace Shape
{
    public class Square : Rectangle
    {
        public Square()
        {

        }

        public Square(double side) : base(side, side)
        {

        }

        public Square(double side, String color, bool filled) : base(side, side, color, filled)
        {

        }

        public double getSide()
        {
            return getWidth();
        }

        public void setSide(double side)
        {
            setWidth(side);
            setLength(side);
        }

        public override void setWidth(double width)

        {

            setSide(width);

        }



        public override void setLength(double length)

        {

            setSide(length);

        }


        public override String ToString()

        {

            return "A Square with side="

                    + getSide()

                    + ", which is a subclass of "

                    + base.ToString();

        }

    }
}