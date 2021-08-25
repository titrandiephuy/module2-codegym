using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class Program
    {
        private const int min = 1;
        private const int max = 4;
        private const int add = 1;
        private const int remove = 2;
        private const int show = 3;
        private const int exit = 4;
        public static Categories product = new Categories();
        public static Client client = new Client();
        static void Main(string[] args)
        {
            AdminMenu();
        }

        public static void BuildMenuAdmin(out int selected)
        {
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Clothing Shop Management System");
                Console.WriteLine("============ADMIN==========");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Show Products");
                Console.WriteLine("4. Exit");
                Console.WriteLine("==========================");
                Console.WriteLine("Choose a function: ");
                selected = Int32.Parse(Console.ReadLine());
            } while (selected < min || selected > max);
        }

        public static void BuildMenuClient(out int selected)
        {
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Welcome to IAN Store!");
                Console.WriteLine("======================");
                Console.WriteLine("Choose all the products that's you want!");
                Console.WriteLine("1. View Shirts");
                Console.WriteLine("2. View Pants");
                Console.WriteLine("3. Show Cart");
                Console.WriteLine("4. Check out !");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==========================");
                Console.WriteLine("Choose a function: ");
                selected = Int32.Parse(Console.ReadLine());
            } while (selected < min || selected > max);
        }
        public static void ClientMenu()
        {
             int selected = 0;
            do
            {
                BuildMenuClient(out selected);
                Console.Clear();
                switch (selected)
                {
                    case add:
                        client.AddToCart();
                        break;
                    case remove:
                        break;
                    case show:
                        product.ViewProduct();
                        break;
                    case exit:
                        Environment.Exit(0);
                        break;
                }

            } while (selected != exit);
        }
        public static void AdminMenu()
        {
            int selected = 0;
            do
            {
                BuildMenuAdmin(out selected);
                Console.Clear();
                switch (selected)
                {
                    case add:
                        product.AddProduct();
                        break;
                    case remove:
                        Console.WriteLine("Enter product name to delete: ");
                        string name = Console.ReadLine();
                        product.RemoveProduct(name);
                        break;
                    case show:
                        product.ViewProduct();
                        break;
                    case exit:
                        Environment.Exit(0);
                        break;
                }

            } while (selected != exit);
        }

    }
}