using System;

namespace Menu2
{
    class Program
    {
        public const int min = 1;
        public const int max = 5;


        static void Main(string[] args)
        {
            Process();
        }

        public static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("+++++++++++++Function Menu:+++++++++++++");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Parallelogram");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Circle");
                Console.WriteLine("5. Exit ");
                Console.WriteLine("=============================================");
                Console.WriteLine("Choose a function: ");
                int.TryParse(Console.ReadLine(), out selected);
            } while (selected < min || selected > max);

        }

        public static void BuildSubMenu(out int choice)
        {
            do
            {
                Console.WriteLine("********Sub Menu:********");
                Console.WriteLine("1. Perimeter of rectangle");
                Console.WriteLine("2. Area of rectangle");
                Console.WriteLine("3. Back to main menu");
                Console.WriteLine("=======================================");
                Console.WriteLine("Choose a function: ");
                int.TryParse(Console.ReadLine(), out int choice);
            } while (choice < 1 || choice > 4);
        }

        public static void Process()
        {
            int selected;
            int h, w, b;
        main_menu:
            do
            {
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case 1:
                        {
                            Console.WriteLine("********Rectangle Menu:********");
                            Console.WriteLine("1. Perimeter of rectangle");
                            Console.WriteLine("2. Area of rectangle");
                            Console.WriteLine("3. Back to main menu");
                            Console.WriteLine("=======================================");
                            Console.WriteLine("Choose a function: ");
                            int.TryParse(Console.ReadLine(), out int choice);
                            switch (choice)
                            {
                                case 1:
                                    h = InputValue("Enter height of Rectangle: ");
                                    w = InputValue("Enter width of Rectangle: ");
                                    Console.WriteLine($"Perimeter of rectangle:{(w + h) * 2}");
                                    break;
                                case 2:
                                    h = InputValue("Enter height of Rectangle: ");
                                    w = InputValue("Enter width of Rectangle: ");
                                    Console.WriteLine($"Area of rectangle:{w * h}");
                                    break;
                                case 3:
                                    goto main_menu;
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("********Parallelogram Menu:********");
                            Console.WriteLine("1. Perimeter of Parallelogram");
                            Console.WriteLine("2. Area of Parallelogram");
                            Console.WriteLine("3. Back to main menu");
                            Console.WriteLine("=======================================");
                            Console.WriteLine("Choose a function: ");
                            int.TryParse(Console.ReadLine(), out int choice);
                            switch (choice)
                            {
                                case 1:
                                    h = InputValue("Enter height of Parallelogram: ");
                                    b = InputValue("Enter base of Parallelogram: ");
                                    Console.WriteLine($"Perimeter of Parallelogram:{(w + b) * 2}");
                                    break;
                                case 2:
                                    h = InputValue("Enter height of Parallelogram: ");
                                    b = InputValue("Enter width of Parallelogram: ");
                                    Console.WriteLine($"Area of Parallelogram:{w * b}");
                                    break;
                                case 3:
                                    goto main_menu;
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("********Triangle Menu:********");
                            Console.WriteLine("1. Perimeter of rectangle");
                            Console.WriteLine("2. Area of rectangle");
                            Console.WriteLine("3. Back to main menu");
                            Console.WriteLine("=======================================");
                            Console.WriteLine("Choose a function: ");
                            int.TryParse(Console.ReadLine(), out int choice);
                            switch (choice)
                            {
                                case 1:
                                    h = InputValue("Enter height of Rectangle: ");
                                    w = InputValue("Enter width of Rectangle: ");
                                    Console.WriteLine($"Perimeter of rectangle:{(w + h) * 2}");
                                    break;
                                case 2:
                                    h = InputValue("Enter height of Rectangle: ");
                                    w = InputValue("Enter width of Rectangle: ");
                                    Console.WriteLine($"Area of rectangle:{w * h}");
                                    break;
                                case 3:
                                    goto main_menu;
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("********Rectangle Menu:********");
                            Console.WriteLine("1. Perimeter of rectangle");
                            Console.WriteLine("2. Area of rectangle");
                            Console.WriteLine("3. Back to main menu");
                            Console.WriteLine("=======================================");
                            Console.WriteLine("Choose a function: ");
                            int.TryParse(Console.ReadLine(), out int choice);
                            switch (choice)
                            {
                                case 1:
                                    h = InputValue("Enter height of Rectangle: ");
                                    w = InputValue("Enter width of Rectangle: ");
                                    Console.WriteLine($"Perimeter of rectangle:{(w + h) * 2}");
                                    break;
                                case 2:
                                    h = InputValue("Enter height of Rectangle: ");
                                    w = InputValue("Enter width of Rectangle: ");
                                    Console.WriteLine($"Area of rectangle:{w * h}");
                                    break;
                                case 3:
                                    goto main_menu;
                            }
                            break;
                        }

                    case 5:
                        Environment.Exit(0);
                        break;
                }
            } while (selected != 5);

        }

        public static int InputValue(string msg)
        {
            int number = 0;
            bool isNumber = true;
            do
            {
                Console.WriteLine(msg);
                int.TryParse(Console.ReadLine(), out number);
            } while (!isNumber);
            return number;
        }
    }
}
