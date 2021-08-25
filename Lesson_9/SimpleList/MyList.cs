using System;
using System.Collections.Generic;
using System.Collections;
namespace SimpleList
{
        class MyListTest
    {
        public static void Main()
        {
            MyList<int> ListInterger = new MyList<int>();
            ListInterger.Add(10);
            ListInterger.Add(15);
            ListInterger.Add(20);
            ListInterger.Add(30);
            ListInterger.Add(50);
            Console.WriteLine("Item 1: " + ListInterger.GetData(1));
            Console.WriteLine("Item 4: " + ListInterger.GetData(4));
            Console.WriteLine("Item 2: " + ListInterger.GetData(2));
            ListInterger.GetData(6);
        }
    }
    class MyList<T>
    {
        private int Capacity { get; set;}

        private Object[] Items;

        public MyList() 
        {
            Items = new Object[10];
        }

        private void EnsureCapacity()
        {
            int newSize = Items.Length * 2;
            Array.Copy(Items, Items, newSize);

        }

        public void Add(T data)
        {
            if(Capacity == Items.Length)
            {
                EnsureCapacity();
            }
            Items[Capacity++] = data;
        }

        public T GetData(int idx)
        {
            if(idx >= Capacity || idx < 0)
            {
                throw new IndexOutOfRangeException("Index: " + idx + " Capacity: " + Capacity);
            }
            return (T)Items[idx];
        }
    }
}

