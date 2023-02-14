using System;

namespace IfIf
{
    class MainApp
    {
        static void Main()
        {
            Console.Write("숫자를 입력하세요. : ");

            string input = Console.ReadLine();
            int num = Int32.Parse(input);

            if (num > 0)
            {
                if (num % 2 == 0)
                    Console.WriteLine("0보다 큰 짝수");
                else
                    Console.WriteLine("0보다 큰 홀수");
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수");
            }
        }
    }
}