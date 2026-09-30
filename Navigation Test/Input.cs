using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Navigation_Test {
    public class Input {
        public static string GetString(string promptText) {
            Console.Clear();
            Console.Write(promptText);
            return Console.ReadLine();
        }

        public static bool IsEmpty(string text) {
            return string.IsNullOrWhiteSpace(text);
        }
    }
}
