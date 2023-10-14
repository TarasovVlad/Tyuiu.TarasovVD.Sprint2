using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint2.Task4.V6.Lib;

namespace Tyuiu.TarasovVD.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 2.333;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 408;
            Assert.AreEqual(wait, res);
        }
    }
}
