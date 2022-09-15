using HumanClock;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HumanClock_Test
{
    [TestClass]
    public class HumanFriendlyClockTest
    {
        [TestMethod]
        public void HumanClock_0100_Test()
        {
            HumanFriendlyClock obj = new HumanFriendlyClock();
            var result = obj.GetHumanFriendlyTime(DateTime.Parse("01:00"));
            Assert.AreEqual(result, "One o' clock");
        }

        [TestMethod]
        public void HumanClock_0205_Test()
        {
            HumanFriendlyClock obj = new HumanFriendlyClock();
            var result = obj.GetHumanFriendlyTime(DateTime.Parse("02:05"));
            Assert.AreEqual(result, "Five past Two");
        }

        [TestMethod]
        public void HumanClock_0430_Test()
        {
            HumanFriendlyClock obj = new HumanFriendlyClock();
            var result = obj.GetHumanFriendlyTime(DateTime.Parse("04:30"));
            Assert.AreEqual(result, "Half past Four");
        }

        [TestMethod]
        public void HumanClock_05035_Test()
        {
            HumanFriendlyClock obj = new HumanFriendlyClock();
            var result = obj.GetHumanFriendlyTime(DateTime.Parse("05:35"));
            Assert.AreEqual(result, "Twenty Five to Six");
        }

        [TestMethod]
        public void HumanClock_0655_Test()
        {
            HumanFriendlyClock obj = new HumanFriendlyClock();
            var result = obj.GetHumanFriendlyTime(DateTime.Parse("06:55"));
            Assert.AreEqual(result, "Five to Seven");
        }

        [TestMethod]
        public void HumanClock_1600_Test()
        {
            HumanFriendlyClock obj = new HumanFriendlyClock();
            var result = obj.GetHumanFriendlyTime(DateTime.Parse("16:00"));
            Assert.AreEqual(result, "Four o' clock");
        }

        [TestMethod]
        public void HumanClock_1305_Test()
        {
            HumanFriendlyClock obj = new HumanFriendlyClock();
            var result = obj.GetHumanFriendlyTime(DateTime.Parse("13:05"));
            Assert.AreEqual(result, "Five past One");
        }

        [TestMethod]
        public void HumanClock_1930_Test()
        {
            HumanFriendlyClock obj = new HumanFriendlyClock();
            var result = obj.GetHumanFriendlyTime(DateTime.Parse("19:30"));
            Assert.AreEqual(result, "Half past Seven");
        }

        [TestMethod]
        public void HumanClock_2359_Test()
        {
            HumanFriendlyClock obj = new HumanFriendlyClock();
            var result = obj.GetHumanFriendlyTime(DateTime.Parse("23:59"));
            Assert.AreEqual(result, "One to Twelve");
        }

    }
}
