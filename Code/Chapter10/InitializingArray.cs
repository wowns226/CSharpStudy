using System;

namespace InitializingArray
{
    class MainApp
    {
        static void Main()
        {
            int[] arr1 = new int[3] { 1, 2, 3 };

            Console.WriteLine("arr1...");
            foreach (var value in arr1)
                Console.WriteLine($" {value}");

            int[] arr2 = new int[] { 1, 2, 3 };

            Console.WriteLine("arr2...");
            foreach (var value in arr2)
                Console.WriteLine($" {value}");

            int[] arr3 = { 1, 2, 3 };

            Console.WriteLine("arr3...");
            foreach (var value in arr3)
                Console.WriteLine($" {value}");
        }
    }
}