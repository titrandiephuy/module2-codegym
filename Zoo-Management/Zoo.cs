using System;

namespace Zoo_Management
{
    class Zoo
    {
        public Cage[] CageList = new Cage[0];
        public void AddCage()
        {
            Cage cage = new Cage();
            Array.Resize(ref CageList, CageList.Length + 1);
            CageList[CageList.Length - 1] = cage;
            cage.CageNumber = Array.IndexOf(CageList, cage) + 1;
            Console.WriteLine($"A cage with number {cage.CageNumber} has been added\n");
        }

        public void RemoveCage()
        {
            Console.WriteLine("Enter cage number to remove: ");
            var c = int.Parse(Console.ReadLine());
            int position = -1;
            for (int i = 0; i < CageList.Length; i++)
            {
                if (CageList[i].CageNumber == c)
                {
                    position = i;
                    break;
                }
            }

            if (position == -1)
            {
                Console.WriteLine("Not found cage in zoo !");
            }
            else
            {
                for (int i = position; i < CageList.Length - 1; i++)
                {
                    CageList[i] = CageList[i + 1];
                }
                Array.Resize(ref CageList, CageList.Length - 1);
            }
        }

        public void ShowZooInfo()
        {
            Console.WriteLine("Zoo information");
            foreach (Cage cage in CageList)
            {
                Console.WriteLine($"Cage: {cage.CageNumber}");
                cage.ShowCageInfo();
            }
        }
    }
}