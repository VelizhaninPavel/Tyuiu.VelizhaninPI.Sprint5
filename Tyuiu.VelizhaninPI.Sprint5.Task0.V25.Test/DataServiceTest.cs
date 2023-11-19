using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint5.Task0.V25.Lib;
using System.IO;

namespace Tyuiu.VelizhaninPI.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string path = @"C:\Users\veliz\source\repos\Tyuiu.VelizhaninPI.Sprint5\Tyuiu.VelizhaninPI.Sprint5.Task0.V25\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
