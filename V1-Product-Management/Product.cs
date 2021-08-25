using System;

namespace V1_Product_Management
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public double Price { get; set;}
        public double[] Rate = new double[0];

        public Product(){

        }

        public Product(string name, string des, double price)
        {
            Name = name;
            Description = des;
            Price = price;
        }

        public void ViewInfo(){
            Console.WriteLine($"Name: {Name}, Description: {Description}, Price: {Price}");
        }
    }
}