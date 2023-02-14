using System;

namespace GenericDelegate
{
    delegate int Compare<T>(T a, T b);

    class MainApp
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Compare(DataSet[j], DataSet[j + 1] > 0))
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main()
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting Ascending...");
            BubbleSort<int>(array, new Compare<int>(AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };
            Consoel.WriteLine("\nSorting Descending...");
            BubbleSort<string>(array, new Compare<string>(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();
        }
    }
}