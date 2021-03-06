using System;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Change();

            Student s1 = new Student(111, "Hoang");
            Student s2 = new Student(222, "Khanh");
            Student s3 = new Student(333, "Nam");

            s1.Display();
            s2.Display();
            s3.Display();
        }
    }

    public class Student
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";
        //constructor to initialize the variable
        public Student(int r, string n)
        {
            rollno = r;
            name = n;
        }

        public static void Change()
        {
            college = "CODEGYM";
        }

        //method to display value
        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}


