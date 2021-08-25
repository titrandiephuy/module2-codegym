using System;

namespace linked_list_queue
{
    class LinkedListQueueClient
    {
        static void Main(string[] args)
        {
            MyLinkedListQueue queue = new MyLinkedListQueue();
            queue.Enqueue(10);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            queue.Enqueue(20);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            Console.WriteLine(queue);
        }
    }
}