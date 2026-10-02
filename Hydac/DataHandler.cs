using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    internal class DataHandler
    {
        public static void SaveData(LogEntry logInfo)
        {
            using (StreamWriter sw = new StreamWriter("GuestLog.txt",true))
            {
                sw.WriteLine(logInfo.ToString());
            }
        }
        

    }
}
