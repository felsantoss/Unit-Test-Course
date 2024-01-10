using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        private const string BAD_FILE_NAME = @"C:\BadFileName.bat"; // Utilização de constante
        private string _GoodFileName;

        [TestMethod]
        public void FileNameDoesExists() // valida se o arquivo existe
        {
            FileProcess fp = new FileProcess(); // Arrange
            bool fromCall;

            fromCall = fp.FileExists(@""); // Act

            Assert.IsTrue(fromCall); // Assert
        }

        [TestMethod]
        public void FileNameDoesNotExists() // valida se o arquivo não existe
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(BAD_FILE_NAME);

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }

        [TestMethod]        
        public void FileNameNullOrEmpty_ThrowsArgumentNullException_TryCatch()
        {
            FileProcess fp = new FileProcess();

            try
            {
                fp.FileExists("");
            }
            catch (ArgumentException)
            {
                // The test was a Sucess
                return;
            }

            Assert.Fail("Fail expected");
        }
    }
}
