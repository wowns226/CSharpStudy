using System;

namespace IntegerLiterals
{
    internal class MainApp
    {
        static void Main()
        {
            // 10진수 리터럴
            byte a = 240;
            Console.WriteLine($"a={a}");

            // 2진수 리터럴
            byte b = 0b1111_0000;
            Console.WriteLine($"b={b}");

            // 16진수 리터럴
            byte c = 0XF0;
            Console.WriteLine($"c={c}");

            // 16진수 리터럴
            uint d = 0x1234_abcd;
            Console.WriteLine($"d={d}");
        }
    }
}