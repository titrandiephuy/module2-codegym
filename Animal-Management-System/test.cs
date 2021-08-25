using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Animal_Management_System
{
    class Test
    {
        int count = 0;
        Hashtable ListAnimal = new Hashtable();
        public void AddCat()
        {
            Cat obj = new Cat();
            obj.ID = count;
            Console.WriteLine("Enter Cat Name: ");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Enter Cat Age: ");
            obj.Age = Int32.Parse(Console.ReadLine() ?? "0");
            ListAnimal.Add(count, obj);
            count++;
        }

        public void AddFish()
        {
            Fish obj = new Fish();
            obj.ID = count;
            Console.WriteLine("Enter Fish Name: ");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Enter Fish Age: ");
            obj.Age = Int32.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }
        public void AddCrocodie()
        {
            Crocodie obj = new Crocodie();
            obj.ID = count;
            Console.WriteLine("Enter Crocodie Name: ");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Enter Crocodie Age: ");
            obj.Age = Int32.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }

        public void ViewTerrestrialAnimal()
        {
            Cat c = new Cat();
            for (int i = 0; i < ListAnimal.Count; i++)
            {
                if (ListAnimal[i].GetType().Equals(c.GetType()))
                {
                    ListAnimal[i].ToString();
                    c.Move();

                }
            }
        }

        public void ViewMarineAnimal()
        {
            Fish f = new Fish();
            for (int i = 0; i < ListAnimal.Count; i++)
            {
                if (ListAnimal[i].GetType().Equals(f.GetType()))
                {
                    ListAnimal[i].ToString();
                    f.Move();

                }
            }

        }
        public void ViewAllAnimal()
        {
            foreach (DictionaryEntry de in ListAnimal)
            {
                Console.WriteLine(de.Value);
            }
        }

        public void DeleteAnimal()
        {
            int n;
            Console.WriteLine("Please select a key: ");
            int.TryParse(Console.ReadLine(), out n);
            foreach (DictionaryEntry de in ListAnimal)
            {
                if(de.Key.Equals(n))
                {
                    ListAnimal.Remove(n);
                    break;
                }
            }
            Console.WriteLine(ListAnimal.Count);
        }
    }
}