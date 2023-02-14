using System;

namespace Sample
{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            MyDelegate callback;

            callback = new MyDelegate(calc.Plus);
            Console.WriteLine(callback(3, 4));

            callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(callback(7, 5));
        }
    }
}