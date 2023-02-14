using System;

namespace Break
{
    class MainApp
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("계속할까요(y/n)? : ");
                string answer = Console.ReadLine();

                if (answer == "n")
                    break;
            }
        }
    }
}