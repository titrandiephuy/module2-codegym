using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class Shirts: Product
    {
        public Shirts()
        {

        }

        public Shirts(string name):base(name)
        {

        }

        public Shirts(string name, string description):base(name, description)
        {

        }

        public Shirts(string id, string name, string description, double price):base(id, name, description, price)
        {

        }
  

        public override string Type()
        {
            return "Shirts";
        }

    }
}