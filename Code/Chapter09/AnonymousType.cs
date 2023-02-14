using System;

namespace AnonymousType
{
    class MainApp
    {
        static void Main()
        {
            var a = new { Name = "임재준", Age = 123 };
            Console.WriteLine($"Name:{a.Name}, Age:{a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };

            Console.Write($"Subject:{b.Subject}, Scores: ");
            foreach (var score in b.Scores)
                Console.Write($"{score} ");

            Console.WriteLine();
        }
    }
}