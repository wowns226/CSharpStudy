using System;

namespace HistoryAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First Release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [History("JaeJun", version = 0.1, changes = "2022-02-15 Created Class Stub")]
    [History("JaeJun", version = 0.2, changes = "2023-02-15 Added Func() Method")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }

    class MainApp
    {
        static void Main()
        {
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("MyClass change history...");

            foreach (Attribute a in attributes)
            {
                History h = a as History;
                if (h != null)
                {
                    Console.WriteLine($"Ver:{h.version}, Programmer:{h.GetProgrammer()}, Changes:{h.changes}");
                }
            }
        }
    }
}