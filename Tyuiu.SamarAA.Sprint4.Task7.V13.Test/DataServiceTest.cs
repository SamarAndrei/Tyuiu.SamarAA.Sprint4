using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint4.Task7.V13.Lib;

namespace Tyuiu.SamarAA.Sprint4.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "159357246";

            int res = ds.Calculate(n,m,str);
            int wait = 3;
            Assert.AreEqual(wait, res);

        }
    }
}
