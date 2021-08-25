using System;

namespace GopMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[5];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"Enter value in arr1[{i}]: ");
                arr1[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"Enter value in arr2[{i}]: ");
                arr2[i] = Int32.Parse(Console.ReadLine());
            }

            int[] arr3 = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
                Console.WriteLine(arr3[i]);
            }

            for (int i = arr1.Length; i < arr3.Length; i++)
            {
                arr3[i] = arr2[arr3.Length - i];
                Console.WriteLine(arr3[i]);
            }

            Console.ReadKey();

        }
    }
}
