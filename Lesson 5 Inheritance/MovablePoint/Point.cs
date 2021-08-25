using System;

namespace MovablePoint
{
    class Point2D
    {
        public float x = 0.0f;
        public float y = 0.0f;

        public float getX()
        {
            return this.x;
        }

        public void setX(float x)
        {
            this.x = x;
        }

        public float getY()
        {
            return this.y;
        }

        public void setY(float y)
        {
            this.y = y;
        }


        public Point2D(float x, float y)
        {
            
        }

        public Point2D()
        {

        }

        public void setXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] getXY()
        {
           float[] array = new float[2] { x, y };
           return array;
        }
    }
}