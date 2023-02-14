using System;

namespace Constructor
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()
        {
            Console.WriteLine($"{Name}의 종료자 실행!");
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class MainApp
    {
        static void Main()
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"Name:{kitty.Name} Color:{kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"Name:{nero.Name} Color:{nero.Color}");
        }
    }
}