using System;

namespace Zoo_Management
{
     class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public string Description { get; set; }
        public void ViewInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} Description: {Description}");
        }

        public virtual void Speak(){

        }

        public Animal(){

        }

        public Animal(string name){
            Name = name;
        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(string name, int age, string des)
        {
            Name = name;
            Age = age;
            Description = des;
        }

    }

        
}