using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public void ViewInfo()
        {
            Console.WriteLine($"ID: {ID}   ||   Name: {Name}    ||  Description: {Description}  ||   Price: {Price}");
        }

        public virtual string Type()
        {
            return "";
        }

        public Product()
        {

        }

        public Product(string name)
        {
            Name = name;
        }

        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Product(string id, string name, string description, double price)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
        }

    }
}