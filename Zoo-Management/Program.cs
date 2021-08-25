using System;

namespace Zoo_Management
{
    class Program
    {
        private const int min = 1;
        private const int max = 6;
        private const int addcage = 1;
        private const int removecage = 2;
        private const int addanimal = 3;
        private const int removeanimal = 4;
        private const int showanimal = 5;
        private const int exit = 6;
        private static Zoo zooService = new Zoo();
        static void Main(string[] args)
        {
            zooService.AddCage();
            zooService.AddCage();

            zooService.CageList[0].AnimalList = new Animal[2]{ 
                new Tiger("Cop", 10, "Cop"),
                new Dog("Cho",15, "Cho")
            };
            zooService.CageList[1].AnimalList = new Animal[3]{
                new Cat("Meo",5,"Meo"),
                new Tiger("Coop", 10, "Coop"),
                new Dog("Cau",5, "Cau")
            };
            Process();


        }

        public static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Zoo Management System");
                Console.WriteLine("======================");
                Console.WriteLine("1. Add Cage");
                Console.WriteLine("2. Remove Cage");
                Console.WriteLine("3. Add Animal");
                Console.WriteLine("4. Remove Animal");
                Console.WriteLine("5. Show Animals");
                Console.WriteLine("6. Exit");
                Console.WriteLine("==========================");
                Console.WriteLine("Choose a function: ");
                selected = Int32.Parse(Console.ReadLine());
            } while (selected < min || selected > max);

        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                BuildMenu(out selected);
                switch (selected)
                {
                    case addcage:
                        zooService.AddCage();
                        break;
                    case removecage:
                        zooService.RemoveCage();
                        break;
                    case addanimal:
                        Console.WriteLine("Choose a cage: ");
                        var num = Convert.ToInt32(Console.ReadLine());
                        foreach (Cage cage in zooService.CageList)
                        {
                            if (cage.CageNumber == num)
                            {
                                cage.AddAnimal();
                            }
                        }

                        break;
                    case removeanimal:
                        Console.WriteLine("Enter animal name: ");
                        string name = Console.ReadLine();
                        foreach (Cage cage in zooService.CageList)
                        {
                            
                            cage.RemoveAnimal(name);

                        }
                        Console.WriteLine("Animal has been removed sucessfully!");
                        break;
                    case showanimal:
                        zooService.ShowZooInfo();
                        break;
                    case exit:
                        Environment.Exit(0);
                        break;
                }

            } while (selected != exit);
        }
    }
}
