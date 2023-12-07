using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.DreminIa.Sprint5.Task3.V29.Lib;

namespace Tyuiu.DreminIa.Sprint5.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Hines\source\repos\Tyuiu.DreminIa.Sprint5\Tyuiu.Dremin.Sprint5\Tyuiu.DreminIa.Sprint5.Task0.V4.Test\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}