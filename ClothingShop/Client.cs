using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
   public class Client
    {
        string path = @"/Users/titrandiephuy/Library/Mobile Documents/com~apple~CloudDocs/Desktop/CodeGym/Module 2 - C#/Module 2 - Exercise/ClothingShop/Data";
        string file = "bill.json";
        List<Product> Cart = new List<Product>();

        public void AddToCart()
        {
            foreach (Product l in Categories.ListProduct)
            {
                l.ViewInfo();
                Console.WriteLine(" Categories: ");
                Console.Write(l.Type());
            }
            Console.WriteLine("Enter Product ID to add to your cart: ");
            var id = Console.ReadLine();
            foreach (Product s in Categories.ListProduct)
            {
                if (s.ID == id)
                {
                    Cart.Add(s);
                }
            }
        }

        public void RemoveFromCart()
        {
            foreach (Product s in Cart)
            {
                s.ViewInfo();
            }
            Console.WriteLine("Enter Product ID to remove from your cart: ");
            var id = Console.ReadLine();
            foreach (Product s in Cart)
            {
                if (s.ID == id)
                {
                    Cart.Remove(s);
                }
            }
        }

        public void ShowCart()
        {
            foreach (Product s in Cart)
            {
                s.ViewInfo();
            }
        }

        public void CheckOut()
        {
            double total = 0;
            foreach (Product p in Cart)
            {
                total += p.Price;
            }
            Console.WriteLine($"Your total is {total}. Do you want to print bill ? Answer Y/N: ");
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                Helper.WriteFile<Product>(Path.Combine(path, "test.json"), Cart);
                Console.WriteLine("Your bill has been printed! Thank you for shopping with us!");
            }
            else
            {
                Console.WriteLine("Checkout successfully! Thank you for shopping with us!");
                Environment.Exit(0);
            }

        }

    }

}