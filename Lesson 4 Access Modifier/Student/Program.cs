using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "M. Cong", "Ha Noi", 30);

            Student student2 = new Student();
            student2.setId(2);
            student2.setName("Ph. Quang Khanh");
            student2.setAddress("Lang Son");
            student2.setAge(25);

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.Read();
        }
    }

    class Student
    {
        private int id;
        private string name;
        private string address;
        private int age;

        public int getId()
        {
            return this.id;
        }

        public void setId(int _id)
        {
            this.id = _id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string _name)
        {
            this.name = _name;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setAddress(string _address)
        {
            this.address = _address;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setAge(int _age)
        {
            this.age = _age;
        }


        public Student() { }
        public Student(int _id, string _name, string _address, int _age)
        {
            this.id = _id;
            this.name = _name;
            this.address = _address;
            this.age = _age;
        }

        public override string ToString()
        {
            return "Id :" + id + " Name : " + name + " Address :" + address + " Age : " + age;
        }
    }
}
