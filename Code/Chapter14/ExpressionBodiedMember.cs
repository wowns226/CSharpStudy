using System;

namespace ExpressionBodiedMember
{
    class FrindList
    {
        private FrindList<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }
        public FrindList() => Console.WriteLine("FriendList()");
        ~FrindList() => Console.WriteLine("~FriendList()");
        //public int Capacity => list.Capacity; // 읽기 전용
        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }
        // public string this[int index] => list[index]; // 읽기 전용
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }

    class MainApp
    {
        static void Main()
        {
            FrindList obj = new FrindList();
            obj.Add("Eeny");
            obj.Add("Meeny");
            obj.Add("Miny");
            obj.Remove("Eney");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Moe";
            obj.PrintAll();
        }
    }
}