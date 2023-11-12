using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint4.Task5.V13.Lib;

namespace Tyuiu.SamarAA.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] { { -1, -1, -1 }, { 1, 4, 2 }, { -2, 1, 3 } };

            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[,] { { 0, 0, 0 }, { 1, 4, 2 }, { 0, 1, 3 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
