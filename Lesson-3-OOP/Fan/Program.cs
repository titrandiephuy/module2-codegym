using System;

namespace Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan = new Fan();
            fan.Speed = fan.medium;
            fan.Radius = 10;
            fan.Color = "yellow";
            fan.On = false;
            fan.Status();
        }
    }

    public class Fan
    {
        public Fan(){

        }

        public int slow = 1;

        public int medium = 2;
        public int fast = 3;
        private int speed = 1;
        private bool on = false;

        private double radius = 5;

        private string color = "blue";

        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        public bool On
        {
            get => on;
            set => on = value;
        }

        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public void Status()
        {
            if (this.on == true)
            {
                Console.WriteLine("Fan is on!");
                Console.WriteLine($"Speed:{speed}, Color: {color}, Radius: {radius}, ");

            }
            else
            {
                Console.WriteLine("Fan is off!");
                Console.WriteLine($"Color: {color}, Radius: {radius}, ");
            }
        }


    }
}
