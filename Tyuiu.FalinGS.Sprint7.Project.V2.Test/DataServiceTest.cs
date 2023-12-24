using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint7.Project.V2.Lib;

namespace Tyuiu.FalinGS.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base1.csv";

            int res = ds.LoadFromDataFile(path);

            int wait = 70146;

            Assert.AreEqual(wait, res);
        }
    }
}
