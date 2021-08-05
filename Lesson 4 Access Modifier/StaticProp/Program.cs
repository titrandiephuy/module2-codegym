using System;

namespace StaticProp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mazda 3", "Skyactiv 3");
            Console.WriteLine(Car.numberOfCars);
            Car car2 = new Car("Mazda 6", "Skyactiv 6");
            Console.WriteLine(Car.numberOfCars);
            Console.ReadLine();
        }
    }

    public class Car {
        private string name;
        private string engine;
        public static int numberOfCars;
        public Car(string name, string engine) 
        {
            this.name = name;
            this.engine = engine;
            numberOfCars++;
        }

        public override bool Equals(object obj)
        {
            return obj is Car car &&
                   name == car.name;
        }
    }
}
