using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyankovaVV.Sprint4.Task5.V25.Lib;

namespace Tyuiu.PyankovaVV.Sprint4.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5]
            {
                {-4, 3, -3, 2, -2 },
                {0, -1, 3, -4, -3 },
                {0, -3, 1, 1, 1 },
                {0, 0, 0, 0, 0 },
                {0, -2, -1, -3, -2 }
            };
            Assert.AreEqual(ds.Calculate(array), 11);
        }
    }
}
