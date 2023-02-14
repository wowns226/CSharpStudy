using System;

namespace _3DArray
{
    class MainApp
    {
        static void Main()
        {
            int[,,] arr = new int[4, 3, 2]
            {
                { {1,2}, {3,4}, {5,6} },
                { {1,4}, {2,5}, {3,6} },
                { {6,5}, {4,3}, {2,1} },
                { {6,3}, {5,2}, {4,1} },
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i, j, k]} ");
                    }
                    Console.Write("} ");
                }
                Console.WriteLine();
            }
        }
    }
}