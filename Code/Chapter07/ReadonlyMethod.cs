using System;

namespace ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;
        public readonly double GetFahrenheit()
        {
            return currentInCelsius * 1.8 + 32;
        }
    }
    class MainApp
    {
        static void Main()
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}