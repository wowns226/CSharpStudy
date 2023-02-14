using System;

namespace InfiniteFor
{
    class MainApp
    {
        static void Main()
        {
            int i = 0;
            for (; ; )
            {
                Console.WriteLine(i++);
            }
        }
    }
}