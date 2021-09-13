using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ClassLibraryPractice
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = ClassLibrary1.Class1.Addition(10, 5);
            Assert.AreEqual(result, 15);
        }
    }
}
