using System;

namespace Overflow
{
    internal class MainApp
    {
        static void Main()
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}