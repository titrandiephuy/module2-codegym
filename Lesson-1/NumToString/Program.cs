using System;

namespace NumToString
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int hundred = n / 100;
            int tens = (n % 100) / 10;
            int ones = (n % 100) % 10;

            if (n < 10 && n > 0)
            {
                switch (n)
                {
                    case 0:
                        Console.Write("Zero");
                        break;
                    case 1:
                        Console.Write(" one");
                        break;
                    case 2:
                        Console.Write(" two");
                        break;
                    case 3:
                        Console.Write(" three");
                        break;
                    case 4:
                        Console.Write(" four");
                        break;
                    case 5:
                        Console.Write(" five");
                        break;
                    case 6:
                        Console.Write(" six");
                        break;
                    case 7:
                        Console.Write(" seven");
                        break;
                    case 8:
                        Console.Write(" eight");
                        break;
                    case 9:
                        Console.Write(" nine");
                        break;
                }
            };

            if (n > 9 && n < 20)
            {
                switch (n)
                {
                    case 10:
                        Console.Write("Ten");
                        break;
                    case 11:
                        Console.Write("Eleven");
                        break;
                    case 12:
                        Console.Write("Twelve");
                        break;
                    case 13:
                        Console.Write("Thirteen");
                        break;
                    case 14:
                        Console.Write("Fourteen");
                        break;
                    case 15:
                        Console.Write("Fifteen");
                        break;
                    case 16:
                        Console.Write("Sixteen");
                        break;
                    case 17:
                        Console.Write("Seventeen");
                        break;
                    case 18:
                        Console.Write("Eighteen");
                        break;
                    case 19:
                        Console.Write("Nineteen");
                        break;
                }
            };

            if (n > 19 && n < 1000)
            {
                switch (hundred)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("One hundred");
                        break;
                    case 2:
                        Console.Write("Two hundreds");
                        break;
                    case 3:
                        Console.Write("Three hundreds");
                        break;
                    case 4:
                        Console.Write("Four hundreds");
                        break;
                    case 5:
                        Console.Write("Five hundreds");
                        break;
                    case 6:
                        Console.Write("Six hundreds");
                        break;
                    case 7:
                        Console.Write("Seven hundreds");
                        break;
                    case 8:
                        Console.Write("Eight hundreds");
                        break;
                    case 9:
                        Console.Write("Nine hundreds");
                        break;
                };

                switch (tens)
                {
                    case 0:
                        Console.Write(" and");
                        break;
                    case 1:
                        switch (ones)
                        {
                            case 0:
                                Console.Write(" Ten");
                                break;
                            case 1:
                                Console.Write(" Eleven");
                                break;
                            case 2:
                                Console.Write(" Twelve");
                                break;
                            case 3:
                                Console.Write(" Thirteen");
                                break;
                            case 4:
                                Console.Write(" Fourteen");
                                break;
                            case 5:
                                Console.Write(" Fifteen");
                                break;
                            case 6:
                                Console.Write(" Sixteen");
                                break;
                            case 7:
                                Console.Write(" Seventeen");
                                break;
                            case 8:
                                Console.Write(" Eighteen");
                                break;
                            case 9:
                                Console.Write(" Nineteen");
                                break;
                        }
                        break;
                    case 2:
                        Console.Write(" and twenty");
                        break;
                    case 3:
                        Console.Write(" and thirty");
                        break;
                    case 4:
                        Console.Write(" and fourty");
                        break;
                    case 5:
                        Console.Write(" and fifty");
                        break;
                    case 6:
                        Console.Write(" and sixty");
                        break;
                    case 7:
                        Console.Write(" and seventy");
                        break;
                    case 8:
                        Console.Write(" and eighty");
                        break;
                    case 9:
                        Console.Write(" and ninety");
                        break;
                };

                switch (ones)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write(" one");
                        break;
                    case 2:
                        Console.Write(" two");
                        break;
                    case 3:
                        Console.Write(" three");
                        break;
                    case 4:
                        Console.Write(" four");
                        break;
                    case 5:
                        Console.Write(" five");
                        break;
                    case 6:
                        Console.Write(" six");
                        break;
                    case 7:
                        Console.Write(" seven");
                        break;
                    case 8:
                        Console.Write(" eight");
                        break;
                    case 9:
                        Console.Write(" nine");
                        break;
                }

            }
        }
    }
}




