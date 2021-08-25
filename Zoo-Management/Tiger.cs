using System;

namespace Zoo_Management
{
    class Tiger : Animal
    {
        public Tiger()
        {

        }

        public Tiger(string name): base(name)
        {

        }

        public Tiger(string name, int age): base(name, age)
        {
        }

        public Tiger(string name, int age, string des):base(name,age,des)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("roarrrrrr!");
        }
    }
}