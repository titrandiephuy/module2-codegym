using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class Shoes: Product
    {
        public Shoes()
        {

        }

        public Shoes(string name):base(name)
        {

        }

        public Shoes(string name, string description):base(name, description)
        {

        }

        public Shoes(string id, string name, string description, double price):base(id, name, description, price)
        {

        }
  

        public override string Type()
        {
            return "Shoes";
        }


    }
}