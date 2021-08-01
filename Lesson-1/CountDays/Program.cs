using System;

namespace CountDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which month that you want to count days ?: ");
            int month = Int32.Parse(Console.ReadLine());

            switch (month) {
                case 2:
                Console.WriteLine($"The month {month} has 28 or 29 days");
                break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                Console.WriteLine($"The month {month} has 31 days");
                break;
                case 4:
                case 6:
                case 9:
                case 11:
                Console.WriteLine($"The month {month} has 30 days");
                break;
                default:
                Console.WriteLine("Invalid input!");
                break;
            }
        }
    }
}
