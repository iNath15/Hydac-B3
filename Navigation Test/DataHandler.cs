using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Navigation_Test {
    internal class DataHandler {
        public static void Save(LogEntry log) {
            string filePath = "Log.txt";

            using (StreamWriter sw = new StreamWriter(filePath, true)) {
                sw.WriteLine(log.ToString());
            }
        }
    }
}
