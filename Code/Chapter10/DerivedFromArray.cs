using System;

namespace DerivedFromArray
{
    class MainApp
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Type of Array : {array.GetType()}");
            Console.WriteLine($"Base type of Array : {array.GetType().BaseType}");
        }
    }
}