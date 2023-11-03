using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint4.Task1.V9.Lib;

namespace Tyuiu.SamarAA.Sprint4.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };
            int res = ds.Calculate(array);
            int wait = 28;
            Assert.AreEqual(wait, res);
        }
    }
}
