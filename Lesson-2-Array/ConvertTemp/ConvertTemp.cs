using System;

namespace ConvertTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Fahrenheit To Celsius");
                Console.WriteLine("2. Celsius To Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Fahrenheit: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to celsius: " + FahrenheitToCelsius(fahrenheit) + " C");
                        break;
                    case 2:
                        Console.WriteLine("Enter Celsius: ");
                        celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius to fahrenheit: " + CelsiusToFahrenheit(celsius) + " F");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while ( choice != 0);
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }
    }
}
