using System;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethod()
        {
            Console.WriteLine("AbstractBase.PrivateMethod()");
        }

        public void PublicMethod()
        {
            Console.WriteLine("AbstractBase.PublicMethod()");
        }

        public void AbstractMethod();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived.AbstractMethod()");
            PrivateMethod();
        }
    }

    class MainApp
    {
        static void Main()
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethod();
            obj.PublicMethod();
        }
    }
}