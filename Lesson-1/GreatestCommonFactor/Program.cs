using System;

namespace GreatestCommonFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("No greater common factor");
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                        a = a - b;
                    else
                        b = b - a;
                }
            }
            Console.WriteLine("Greatest common factor: " + a);

        }
    }
}
// using System;

// namespace GreatestCommonFactor
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i, j, uscln = 1;
//             Console.WriteLine("Enter a: ");
//             int a = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter b: ");
//             int b = Convert.ToInt32(Console.ReadLine());

//             a = Math.Abs(a);
//             b = Math.Abs(b);

//             j = (a < b) ? a : b;
//             for (i = 1; i <= j; i++)
//             {
//                 if (a % i == 0 && b % i == 0)
//                 {
//                     uscln = i;
//                 }
//             }
//             Console.WriteLine("Greatest common factor: " + uscln);

//         }
//     }
// }
