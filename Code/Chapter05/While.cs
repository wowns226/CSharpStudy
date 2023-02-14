using System;

namespace While
{
    class MainApp
    {
        static void Main()
        {
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine($"i : {i--}");
            }
        }
    }
}
