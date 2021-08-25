using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop
{
    class Pants: Product
    {
        public Pants()
        {

        }

        public Pants(string name):base(name)
        {

        }

        public Pants(string name, string description):base(name, description)
        {

        }

        public Pants(string id, string name, string description, double price):base(id, name, description, price)
        {

        }
  

        public override string Type()
        {
            return "Pants";
        }


    }
}