using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyankovaVV.Sprint4.Task6.V20.Lib;

namespace Tyuiu.PyankovaVV.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            DataService ds = new DataService();
            string[] mas = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] wait = { "Физика", "Химия", "Биология", "География", "История" };
            string[] res = ds.Calculate(mas);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
