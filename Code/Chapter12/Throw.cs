using System;

namespace Throw
{
    class MainApp
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg:{arg}");
            else
                throw new Exception("arg가 10보다 큽니다.");
        }

        static void Main()
        {
            try
            {
                DoSomething(1);
                DoSomething(5);
                DoSomething(9);
                DoSomething(13);
                DoSomething(17);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}