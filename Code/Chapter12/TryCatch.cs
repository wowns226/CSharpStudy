using System;

namespace TryCatch
{
    class MainApp
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외 발생! : {e.Message}");
            }

            Console.WriteLine("종료");
        }
    }
}