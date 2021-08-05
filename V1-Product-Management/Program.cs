using System;

namespace V1_Product_Management
{
    class Program
    {
        public const int min = 1;
        public const int max = 5;
        static void Main(string[] args)
        {

        }

        public static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("PRODUCT MANAGEMENT SYSTEM:");
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Remove product");
                Console.WriteLine("3. Iterate product list");
                Console.WriteLine("4. Search product");
                Console.WriteLine("5. Exit ");
                Console.WriteLine("=============================================");
                Console.WriteLine("Choose a function: ");
                int.TryParse(Console.ReadLine(), out selected);
            } while (selected < min || selected > max);

        }

        public static void AddProduct(out int choice)
        {
            do
            {
                Console.WriteLine("Add Product Menu:");
                Console.WriteLine("1. Enter product name: ");
                
                Console.WriteLine("2. Enter product description: ");
                Console.WriteLine("3. Enter product price: ");
                Console.WriteLine("4. Enter product rate: ")
                Console.WriteLine(". Back to main menu");
                Console.WriteLine("=======================================");
                Console.WriteLine("Choose a function: ");
                int.TryParse(Console.ReadLine(), out int choice);
            } while (choice < min || choice > max);

        }

        public static void Process()
        {
            int selected;
            int choice;
            do
            {
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {

                }

            } while (selected != 5);
        }
    }
}
