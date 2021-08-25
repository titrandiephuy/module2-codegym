using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Animal_Management_System
{
    public class Cat: ITerrestrialAnimal
    {
        int id { get; set;}
        string? name { get; set;}
        int age { get; set;}
        public int ID { get => id; set => id=value; }
        public string? Name { get => name; set => name=value; }
        public int Age { get => age; set => age=value; }

        public void Move()
        {
            Console.WriteLine("RUN!");
        }

        public override string ToString()
        {
            Console.WriteLine(GetType());
            Console.WriteLine("Animal ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            return " ";
        }
    }
}