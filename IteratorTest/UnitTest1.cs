using Iterator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IteratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConcreateAggregateTest()
        {
            ConcreateAggregate list = new ConcreateAggregate();
            list[0] = "Item 1";
            list[1] = "Item 2";

            string expected = "Item 1";
            string actual = list[0].ToString();

            Assert.AreEqual(expected, actual);

        }
    }
}
