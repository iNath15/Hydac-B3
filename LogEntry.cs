using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    public class LogEntry
    {
        public string Name { get; }
        public string BusinessName { get; }
        public string ResponsibleName { get; }
        public DateTime ArrivalTime { get; }

        public LogEntry(string name, string businessName, string responsibleName, DateTime arrivalTime)
        {
            Name = name;
            BusinessName = businessName;
            ResponsibleName = responsibleName;
            ArrivalTime = arrivalTime;
        }

        public LogEntry(string name, string businessName, string responsibleName):
            this(name, businessName, responsibleName, DateTime.Now)
        { }

        public override string ToString()
        {
            return $"{ArrivalTime:yyyy-MM-dd HH\\:mm\\:ss};{Name};{BusinessName};{ResponsibleName}";
        }
    }
}
