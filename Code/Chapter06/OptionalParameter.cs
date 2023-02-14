using System;

namespace OptionalParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name} Phone:{phone}");
        }

        static void Main()
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-1234-5678");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-8765-4321");
        }
    }
}