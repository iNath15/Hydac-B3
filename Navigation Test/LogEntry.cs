using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Navigation_Test {
    internal class LogEntry {
        public string Name { get; }
        public string BusinessName { get; }
        public string ResponsibleName { get; }
        public DateTime Arrival { get; }
        public DateTime? Departure { get; private set; }

        public LogEntry(string name, string businessName, string responsibleName, DateTime arrival) {
            Name = name;
            BusinessName = businessName;
            ResponsibleName = responsibleName;
            Arrival = arrival;
            Departure = null;

        }

        public LogEntry(string name, string businessName, string responsibleName) :
            this(name, businessName, responsibleName, DateTime.Now) { }

        public override string ToString() {
            if (Departure == null) {
                return $"{Arrival:yyyy-MM-dd HH:mm:ss};null;{Name};{BusinessName};{ResponsibleName}";
            }
            return $"{Arrival:yyyy-MM-dd HH:mm:ss};{Departure};{Name};{BusinessName};{ResponsibleName}";
        }

        public void SetDeparture() {
            Departure = DateTime.Now;
        }
    }
}
