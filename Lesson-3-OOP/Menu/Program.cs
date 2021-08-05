using System;

namespace Menu
{
    class Program
    {
        public const int addition = 1;
        public const int subtraction = 2;
        public const int multiple = 3;
        public const int division = 4;
        public const int exit = 5;
        public const int min = 1;
        public const int max = 5;

        static void Main(string[] args)
        {
            Process();

        }

        private static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("===========================CALCULATOR============================");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiple");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==================================================================");
                Console.WriteLine("Choose a function: ");
                int.TryParse(Console.ReadLine(), out selected);
            } while (selected < min || selected > max);
        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case addition:
                        {
                            int number1 = InputNumber("Enter number 1: ");
                            int number2 = InputNumber("Enter number 2: ");
                            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                            break;
                        }


                    case subtraction:{
                        int number1 = InputNumber("Enter number subtrahend: ");
                        int number2 = InputNumber("Enter number minuend: ");
                        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                        break;
                    }


                    case multiple:{
                        int number1 = InputNumber("Enter number 1: ");
                        int number2 = InputNumber("Enter number 2: ");
                        Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
                        break;
                    }


                    case division:{
                        int number1 = InputNumber("Enter number diviend: ");
                        int number2 = InputNumber("Enter number divisor: ");
                        if (number2 == 0)
                        {
                            Console.WriteLine("Divided by zero.");
                        }
                        else
                        {
                            Console.WriteLine($"{number1} : {number2} = {number1 / number2}");
                        }
                        break;
                    }


                    case exit:{
                        Environment.Exit(0);
                        break;
                    }


                }
            } while (selected != exit);


        }

        public static int InputNumber(string msg)
        {
            int number = 0;
            bool isNumber = true;
            do
            {
                Console.Write(msg);
                isNumber = int.TryParse(Console.ReadLine(), out number);
            }
            while (!isNumber);
            return number;
        }
    }
}
