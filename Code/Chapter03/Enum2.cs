using System;

namespace Enum2
{
    internal class MainApp
    {
        enum DialogResult
        {
            YES,
            NO,
            CANCEL,
            CONFIRM,
            OK
        }

        static void Main()
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);
        }
    }
}