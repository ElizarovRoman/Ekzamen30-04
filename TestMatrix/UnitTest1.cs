using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TestMatrix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            int[] matrix1 = new [] { 1, 2, 3, 3, 5 };
            int[] matrix2 = new[] { 1, 2, 3, 4, 5 };
            bool expected = false;
            //act
            bool actual = TestedClass.test(matrix1, matrix2);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
