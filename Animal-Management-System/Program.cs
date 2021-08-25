using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Animal_Management_System
{
    class Program
    {
        public static void Main(string[] args)
        {
            Test t = new Test();
            int choice;
            Console.WriteLine("1. Create a Crocodie");
            Console.WriteLine("2. Create a Cat");
            Console.WriteLine("3. Create a Fish");
            Console.WriteLine("4. View Terrestrial Animal");
            Console.WriteLine("5. View Marine Animal");
            Console.WriteLine("6. View All Animal");
            Console.WriteLine("7. Remove Animal");
            Console.WriteLine("8. Exit");
            do
            {
                Console.WriteLine("Please select a function: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                    t.AddCrocodie();
                    break;
                    case 2:
                    t.AddCat();
                    break;
                    case 3:
                    t.AddFish();
                    break;
                    case 4:
                    t.ViewTerrestrialAnimal();
                    break;
                    case 5:
                    t.ViewMarineAnimal();
                    break;
                    case 6:
                    t.ViewAllAnimal();
                    break;
                    case 7:
                    t.DeleteAnimal();
                    break;
                    case 8: return;
                }
            } while (choice != 8);
        }
    }
}