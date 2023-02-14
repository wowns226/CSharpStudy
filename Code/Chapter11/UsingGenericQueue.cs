using System;
using System.Collections.Generic;

namespace UsingGenericQueue
{
    class MainApp
    {
        static void Main()
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());
        }
    }
}