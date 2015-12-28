using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTF8MacConvert
{
    [TestClass]
    public class UnitTest1
    {
        // 44Gv44Ka44Gy44Ka44G144Ka44G444Ka44G744Ka44OP44Ka44OS44Ka44OV44Ka44OY44Ka44Ob44Ka
        string utf8_mac = "ぱぴぷぺぽパピプペポ"; //NFD

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(false, utf8_mac.IsNormalized());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var changed = utf8_mac.Normalize();
            Assert.AreEqual("ぱぴぷぺぽパピプペポ", changed); // NFC
            Assert.AreEqual(true, changed.IsNormalized());
        }
    }
}
