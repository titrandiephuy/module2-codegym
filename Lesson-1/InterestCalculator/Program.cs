using System;

namespace InterestCalculator
{
    class Interest
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double interestRate = 1.0;

            Console.WriteLine("Enter investment amount: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of month: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter annual interest rate in percentage: ");
            interestRate = Double.Parse(Console.ReadLine());

            double totalInterest = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterest = money * (interestRate/100) / 12 * month;
            }
            Console.WriteLine("Total of interest is: " + totalInterest);
        }
    }
}
