using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint5.Task2.V24.Lib;
using System.IO;

namespace Tyuiu.VelizhaninPI.Sprint5.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string path = @"C:\Users\veliz\source\repos\Tyuiu.VelizhaninPI.Sprint5\Tyuiu.VelizhaninPI.Sprint5.Task1.V21\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
