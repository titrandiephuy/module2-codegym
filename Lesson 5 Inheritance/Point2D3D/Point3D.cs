using System;

namespace Point2D3D
{
    class Point3D : Point2D
    {
        public float z = 0.0f;

        public float getZ()
        {
            return this.z;
        }

        public void setZ(float z)
        {
            this.z = z;
        }


        public Point3D(float x, float y): base(x, y)
        {

        }
        public Point3D()
        {

        }

        public void setXYZ(float x, float y, float z)
        {

        }

        public void getXYZ()
        {
           float[] arr = new float[3] { x, y, z };
        }

                public override string ToString()
        {
            return $"(z {z}" + base.ToString();
        }
    }
}