using System;

namespace Zoo_Management
{
    class Dog : Animal
    {
        public Dog()
        {

        }

        public Dog(string name): base(name)
        {

        }

        public Dog(string name, int age): base(name, age)
        {

        }

        public Dog(string name, int age, string des):base(name, age, des)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("woof-woof!");
        }
    }
}