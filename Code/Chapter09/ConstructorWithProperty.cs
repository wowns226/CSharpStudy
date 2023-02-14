using System;

namespace AutoImplementedProperty
{
    class BirthDayInfo
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year; }
        }
    }



    class MainApp
    {
        static void Main()
        {
            BirthDayInfo birth = new BirthDayInfo()
            {
                Name = "서현",
                Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}