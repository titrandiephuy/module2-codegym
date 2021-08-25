using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class Categories
    {
        private const int shirts = 1;
        private const int pants = 2;
        private const int shoes = 3;

       public static List<Product> ListProduct = new List<Product>();

        public void AddProduct()
        {
            int selected;
            Console.Clear();
            do
            {
                Console.WriteLine("1. Add Shirts");
                Console.WriteLine("2. Add Pants");
                Console.WriteLine("3. Add Shoes");
                Console.WriteLine("======================");
                Console.WriteLine("Choose products you want to add: ");
                selected = Int32.Parse(Console.ReadLine());
            } while (selected > 3 || selected < 1);

            switch (selected)
            {
                case shirts:
                    AddShirts();
                    Console.WriteLine("Shirts added sucessfully!\n");
                    break;
                case pants:
                    AddPants();
                    Console.WriteLine("Pants added sucessfully!\n");
                    break;
                case shoes:
                    AddShoes();
                    Console.WriteLine("Shoes added sucessfully!\n");
                    break;
            }
        }

        public void ViewProduct()
        {
            int selected;
            Console.Clear();
            do
            {
                Console.WriteLine("1. View Shirts");
                Console.WriteLine("2. View Pants");
                Console.WriteLine("3. View Shoes");
                Console.WriteLine("4. View All Products");
                Console.WriteLine("======================");
                Console.WriteLine("Choose products you want to see: ");
                selected = Int32.Parse(Console.ReadLine());
            } while (selected < 1 || selected > 4);
            switch (selected)
            {
                case shirts:
                    ViewShirts();
                    break;
                case pants:
                    ViewPants();
                    break;
                case shoes:
                    ViewShoes();
                    break;
                case 4:
                    ViewAllProduct();
                    break;
            }
        }

        public void AddShirts()
        {
            Console.WriteLine("Enter Product ID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Enter Shirts Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Shirts Description: ");
            var description = Console.ReadLine();
            Console.WriteLine("Enter Shirts Price: ");
            var price = Int32.Parse(Console.ReadLine());
            Shirts obj = new Shirts(id, name, description, price);
            ListProduct.Add(obj);
        }

        public void AddPants()
        {
            Console.WriteLine("Enter Product ID: ");
            var id =Console.ReadLine();
            Console.WriteLine("Enter Pants Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Pants Description: ");
            var description = Console.ReadLine();
            Console.WriteLine("Enter Pants Price: ");
            var price = Int32.Parse(Console.ReadLine());
            Pants obj = new Pants(id, name, description, price);
            ListProduct.Add(obj);
        }

        public void AddShoes()
        {
            Console.WriteLine("Enter Product ID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Enter Shoes Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Shoes Description: ");
            var description = Console.ReadLine();
            Console.WriteLine("Enter Shoes Price: ");
            var price = Int32.Parse(Console.ReadLine());
            Shoes obj = new Shoes(id, name, description, price);
            ListProduct.Add(obj);
        }

        public void RemoveProduct(string name)
        {
            Product s = ListProduct.Find(s => s.Name.Contains(name));
            if (s != null)
            {
                ListProduct.Remove(s);
                Console.WriteLine("Product has been removed sucessfully!");
            }
            else
            {
                Console.WriteLine("Can't find product name!");
            }

        }

        public void ViewAllProduct()
        {
            foreach (Product l in ListProduct)
            {
                l.ViewInfo();
                Console.WriteLine(" Categories: ");
                Console.Write(l.Type());
            }
        }

        public void ViewShirts()
        {
            Console.WriteLine("     ======Shirts======      ");
            foreach (Product s in ListProduct)
            {
                if (s.Type() == "Shirts")
                {
                    s.ViewInfo();
                }
            }
        }

        public void ViewPants()
        {
            Console.WriteLine("     ======Pants======       ");
            foreach (Product s in ListProduct)
            {
                if (s.Type() == "Pants")
                {
                    s.ViewInfo();
                }
            }
        }

        public void ViewShoes()
        {
            Console.WriteLine("     ======Shoes======       ");
            foreach (Product s in ListProduct)
            {
                if (s.Type() == "Shoes")
                {
                    s.ViewInfo();
                }
            }
        }

    }
}