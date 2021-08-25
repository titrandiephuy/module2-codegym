using System;

namespace Zoo_Management
{
    class Cat : Animal
    {
        public Cat()
        {

        }

        public Cat(string name): base(name)
        {

        }

        public Cat(string name, int age): base(name, age)
        {
            
        }

        public Cat(string name, int age, string des):base(name, age, des)
        {

        }

        public override void Speak()
        {
            Console.WriteLine("meow-meow!");
        }
    }
}