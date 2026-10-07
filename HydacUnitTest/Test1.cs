using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hydac;

namespace Hydac.Tests {
    [TestClass]
    public class LogEntryTests {
        [TestMethod]
        public void Constructor_ShouldSetPropertiesCorrectly() {
            DateTime arrivalTime = new DateTime(2026, 10, 6, 10, 30, 0);
            LogEntry logEntry = new LogEntry("Peter", "Microsoft", "Jens", arrivalTime);

            Assert.AreEqual("Peter", logEntry.Name);
            Assert.AreEqual("Microsoft", logEntry.BusinessName);
            Assert.AreEqual("Jens", logEntry.ResponsibleName);
            Assert.AreEqual(arrivalTime, logEntry.ArrivalTime);
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectFormat() {
            DateTime arrivalTime = new DateTime(2026, 10, 6, 10, 30, 15);
            LogEntry logEntry = new LogEntry("Peter", "Microsoft", "Jens", arrivalTime);

            string expected = "2026-10-06 10:30:15;Peter;Microsoft;Jens";
            string result = logEntry.ToString();

            Assert.AreEqual(expected, result);
        }
    }
}