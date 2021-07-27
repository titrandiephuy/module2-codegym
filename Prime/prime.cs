using System;

namespace Prime
{
    class Prime
    {
        static void Main(String[] args)
        {
            int number;
            Console.WriteLine("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2)
            Console.WriteLine(number + " is not a prime");
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0) {
                        check = false;
                        break;
                    }
                    i++;
                }
                if(check)
                {
                    Console.WriteLine(number + " is a prime");
                }
                else {
                    Console.WriteLine(number + " is not a prime");
                }
                }
            }
        }
    }