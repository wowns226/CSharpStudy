using System;

namespace IncDecOperator
{
    class MainApp
    {
        static void Main()
        {
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
    }
}