using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTF8MacConvert
{
    [TestClass]
    public class UnitTest1
    {
        // 44Gx44G044G344G644G944OR44OU44OX44Oa44Od
        string utf8_nfc = "ぱぴぷぺぽパピプペポ"; // NFC

        // 44Gv44Ka44Gy44Ka44G144Ka44G444Ka44G744Ka44OP44Ka44OS44Ka44OV44Ka44OY44Ka44Ob44Ka
        string utf8_nfd = "ぱぴぷぺぽパピプペポ"; //NFD

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreNotEqual(utf8_nfc, utf8_nfd);
            Assert.AreEqual(false, utf8_nfd.IsNormalized());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var changed = utf8_nfd.Normalize();
            Assert.AreEqual(utf8_nfc, changed);
            Assert.AreEqual(true, changed.IsNormalized());
        }
    }
}
