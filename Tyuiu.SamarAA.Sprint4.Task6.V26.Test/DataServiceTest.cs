using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint4.Task6.V26.Lib;

namespace Tyuiu.SamarAA.Sprint4.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var array = new string[] {"Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
            string[] res = ds.Calculate(array);
            string[] wait = new string[] {"Тюмень", "Тамбов" };

            Assert.AreEqual(wait, res);
        }
    }
}
