using System;

namespace MinArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The smallest value of array is: {MinArray()} ");
            Console.ReadKey();
        }

        public static int MinArray()
        {
            int size = 5;
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {   
                Console.WriteLine($"Enter value arr at index {i}: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            int min = arr[0];
            for (int i = 0; i < size; i++)
            {
                if(min > arr[i]){
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
