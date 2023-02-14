using System;

namespace NamedParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name:{name} Phone:{phone}");
        }

        static void Main()
        {
            PrintProfile(name: "박찬호", phone: "010-1234-5678");
            PrintProfile(phone: "010-9876-5432", name: "박지성");
            PrintProfile("박세리", "010-222-2222");
            PrintProfile("박상현", phone: "010-123-1234");
        }
    }
}