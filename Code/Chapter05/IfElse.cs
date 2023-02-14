using System;

namespace IfElse
{
    class MainApp
    {
        static void Main()
        {
            Console.Write("숫자를 입력하세요. : ");

            string input = Console.ReadLine();
            int num = Int32.Parse(input);

            if (num < 0)
                Console.WriteLine("음수");
            else if (num > 0)
                Console.WriteLine("양수");
            else
                Console.WriteLine("0");

            if (num % 2 == 0)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("혹수");
        }
    }
}