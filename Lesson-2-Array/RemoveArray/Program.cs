using System;

namespace RemoveArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array with 10 elements
            int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int x;
            int index_del = 0;

            // Enter number to remove
            Console.WriteLine("Enter number to remove: ");
            x = Convert.ToInt32(Console.ReadLine());

            //Find x in Array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {

                    index_del = i;
                }
            }
            // remove x
            for (int j = index_del; j < array.Length - 1; j++)
            {
                array[j] = array[j + 1];
            }

            Console.WriteLine("Array after:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();

        }
    }
}
