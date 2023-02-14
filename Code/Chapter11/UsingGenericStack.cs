using System;
using System.Collections.Generic;

namespace UsingGenericStack
{
    class MainApp
    {
        static void Main()
        {
            Stack<int> st = new Stack<int>();

            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            while (st.Count > 0)
                Console.WriteLine(st.Pop());
        }
    }
}