using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RagimovaMA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.RagimovaMA.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("19.05", ds.FindDateOfPreviousDay(5, 20));
            Assert.AreEqual("31.03", ds.FindDateOfPreviousDay(4, 1));
            Assert.AreEqual("29.07", ds.FindDateOfPreviousDay(7, 30));
            Assert.AreEqual("31.08", ds.FindDateOfPreviousDay(9, 1));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(14, 32);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(13, 32);
            });
        }
    }
}
