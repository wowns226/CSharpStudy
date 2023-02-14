using System;

namespace Switch2
{
    class MainApp
    {
        static void Main()
        {
            object obj = null;

            string s = Console.ReadLine();

            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"{i}는 int 형식입니다");
                    break;
                case float f when f >= 0:
                    // obj가 float 형식이면서 0보다 크거나 같을 때
                    Console.WriteLine($"{f}는 양의 float 형식입니다");
                    break;
                case float f:
                    // obj가 float 형식이면서 0보다 작을 때
                    Console.WriteLine($"{f}는 음의 float 형식입니다");
                    break;
                default:
                    Console.WriteLine($"{obj}는 모르는 형식입니다");
                    break;
            }
        }
    }
}
