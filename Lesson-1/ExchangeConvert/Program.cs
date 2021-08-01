using System;

namespace ExchangeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, b = new int[3];

            a[9] = b[0];

            Console.WriteLine(a[9]);
        }
    }
}
