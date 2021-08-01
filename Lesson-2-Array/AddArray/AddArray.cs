using System;

namespace AddArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, p;
            int[] array;
            Console.WriteLine("Enter array size: ");
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("Enter elements: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter element you want to add in array: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Enter position you want to add: ");
            p = Int32.Parse(Console.ReadLine());

            if (p <= 1 && p >= array.Length - 1)
            {
                Console.WriteLine("Can't add value");
            }

            Console.WriteLine("Array before:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }

            Array.Resize(ref array, n = n + 1);

            for (int i = n; i >= p; i--)
            {
                array[i] = array[i - 1];
            }
            array[p - 1] = x;


            Console.WriteLine("Array after:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }


    }
}
