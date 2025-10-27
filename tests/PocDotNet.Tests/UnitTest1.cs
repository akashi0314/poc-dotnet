using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PocDotNet.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var expected = "Hello, World!";
            var actual = GetHelloWorld();

            // Act & Assert
            Assert.AreEqual(expected, actual);
        }

        private string GetHelloWorld()
        {
            return "Hello, World!";
        }
    }
}