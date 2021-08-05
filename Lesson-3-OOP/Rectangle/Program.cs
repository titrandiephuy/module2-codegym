﻿using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width: ");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            double height = Double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("Your Rectangle \n" + rectangle.Display());
            Console.WriteLine("Perimeter of the rectangle \n" + rectangle.GetPerimeter());
            Console.WriteLine("Area of the rectangle \n" + rectangle.GetArea());
        }
    }

    public class Rectangle {
        double width, height;

        public Rectangle () {

        }

        public Rectangle (double width, double height) {
            this.width = width;
            this.height = height;
        }

        public double GetArea () {
            return this.width * this.height;
        }

        public double GetPerimeter () {
            return (this.width + this.height) * 2;
        }

        public string Display() {
            return "Rectangle{" + "width=" + this.width + "," + "height=" + this.height + "}";
        }
    }
}
