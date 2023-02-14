using System;

namespace CopyingArray
{
    class MainApp
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static void Main()
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach (var element in target)
            {
                Console.WriteLine(element);
            }

            string[] source2 = { "one", "two", "three", "four", "five" };
            string[] target2 = new string[source2.Length];

            CopyArray<int>(source2, target2);

            foreach (var element in target2)
            {
                Console.WriteLine(element);
            }
        }
    }
}