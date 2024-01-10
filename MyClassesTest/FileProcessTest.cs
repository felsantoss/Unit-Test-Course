using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExists() // valida se o arquivo existe
        {
            FileProcess fp = new FileProcess(); // Arrange
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe"); // Act

            Assert.IsTrue(fromCall); // Assert
        }

        [TestMethod]
        public void FileNameDoesNotExists() // valida se o arquivo não existe
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Regedit.exe");

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            //TODO
            Assert.Inconclusive();
        }
    }
}
