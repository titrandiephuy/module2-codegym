using System;
using System.Collections.Generic;
using System.Collections;

namespace stack
{
    public class MyStack
    {
        private int[] arr;
        private int size;
        private int index;

        public MyStack(int size)
        {
            this.size = size;
            arr = new int[size];
        }
    }
}