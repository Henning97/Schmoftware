using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schmoftware;

namespace UnitTestSchmoftware
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFakultaet()
        {
            Fakultaet fakultaet = new Fakultaet();

            Assert.AreEqual(fakultaet.GetFakultaet(0), (ulong)1);
        }

        [TestMethod]
        public void TestFakultaet2()
        {
            Fakultaet fakultaet = new Fakultaet();

            Assert.AreEqual(fakultaet.GetFakultaet(5), (ulong)120);
        }
    }
}
