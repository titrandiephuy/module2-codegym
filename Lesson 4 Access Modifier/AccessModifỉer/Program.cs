using System;

namespace AccessModifỉer
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicLib.Class1 pc = new PublicLib.Class1();
            int sum = pc.Sum(1,2);
            Console.WriteLine("sum = " + sum);

            InternalLib.Class1 ic = new InternalLib.Class1();
            sum = ic.Sum(1,3);
            Console.WriteLine("sum = " + sum);
        }
    }
}
