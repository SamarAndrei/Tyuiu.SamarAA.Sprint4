using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint4.Task2.V22.Lib;

namespace Tyuiu.SamarAA.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 1, 1, 3, 4, 5 };

            int res = ds.Calculate(array);
            int wait = 15;

            Assert.AreEqual(wait, res);
        }
    }
}
