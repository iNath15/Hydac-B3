using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Navigation_Test {
    internal class DataHandler {
        public static void Save(LogEntry log) {

            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Hydac");

            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, "Guestlog.txt");

            using (StreamWriter sw = new StreamWriter(filePath, true)) {
                sw.WriteLine(log.ToString());
            }
        }
    }
}
