using System;

namespace V1_Product_Management
{
    class Shop
    {
        public Product[] ProductList = new Product[4]{
            new Product(){
                Name = "Coca",
                Description = "Soft drink",
                Price=10000,
                Rate = new double[2] {2,3}
            },
            new Product(){
                Name = "Pepsi",
                Description = "Soft drink",
                Price=10000,
                Rate = new double[2]{2,3}
            },
            new Product(){
                Name = "Fanta",
                Description = "Soft drink",
                Price=8000,
                Rate = new double[2]{2,3}
            },
            new Product(){
                Name = "Sprite",
                Description = "Soft drink",
                Price=6000,
                Rate = new double[2]{2,3}
            },
        };

        public void AddProduct()
        {
            Console.WriteLine("Enter product name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter product description: ");
            var des = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            var price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter product rate point: ");
            var rate = Double.Parse(Console.ReadLine());

            var product = new Product(name, des, price);
            Array.Resize(ref product.Rate, product.Rate.Length + 1);
            product.Rate[product.Rate.Length - 1] = rate;
            Array.Resize(ref ProductList, ProductList.Length + 1);
            ProductList[ProductList.Length - 1] = product;
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Enter product name to remove: ");
            var name = Console.ReadLine();
            int position = -1;
            for (int i = 0; i < ProductList.Length; i++)
            {
                if (string.Compare(ProductList[i].Name.ToLower(), name.ToLower()) == 0)
                {
                    position = i;
                    break;
                }
            }

            for (int i = position; i < ProductList.Length - 1; i++)
            {
                ProductList[i] = ProductList[i + 1];
            }
            Array.Resize(ref ProductList, ProductList.Length - 1);
        }

        public void ShowProduct()
        {
            foreach (Product item in ProductList)
            {
                item.ViewInfo();
                double total = 0;
                foreach (int value in item.Rate)
                {
                    total += value;
                }
                Console.WriteLine($"Average rate: {total}");
            }
        }

        public void SearchProduct()
        {
            Console.WriteLine("Enter min price: ");
            var min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter max price: ");
            var max = Int32.Parse(Console.ReadLine());
            bool exist = false;

            foreach (Product pr in ProductList)
            {
                if (pr.Price >= min && pr.Price <= max)
                {
                    pr.ViewInfo();
                    exist = true;
                    double total = 0;
                    foreach (int value in pr.Rate)
                    {
                        total += value;
                    }
                    Console.WriteLine($"Average rate: {total}");
                }
            }
            if (!exist)
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}