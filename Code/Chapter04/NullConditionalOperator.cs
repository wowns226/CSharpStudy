using System;
using System.Collections;

namespace NullConditionalOperator
{
    class MainApp
    {
        static void Main()
        {
            ArrayList a = null;
            // a?.가 null을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("야구");
            a?.Add("축구");
            // a?.가 null을 반환하므로 Count 외에는 아무것도 출력하지 않는다
            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

            a = new ArrayList();
            a?.Add("야구");
            a?.Add("축구");
            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");
        }
    }
}