using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    internal class Input
    {
        public static string getString(string promptText)
        {
            Console.Clear();
            Console.Write(promptText);
            return Console.ReadLine();
        }

    }
}
