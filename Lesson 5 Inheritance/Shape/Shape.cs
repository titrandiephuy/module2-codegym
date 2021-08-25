using System;

namespace Shape
{
    public class Shape
    {
        private String color = "green";
        private bool filled = true;

        public string getColor()
        {
            return this.color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public bool isFilled()
        {
            return this.filled;
        }

        public void setFilled(bool filled)
        {
            this.filled = filled;
        }

        public Shape()
        {
  
        }
        public Shape(String color, bool filled) {
            this.color = color;
            this.filled = filled;
        }
        
        public override String ToString()
        {
            return "A shape with color of " + getColor() + " and" + (isFilled()?" filled" : " not filled");
        }

    }
}