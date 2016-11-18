using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortableHotspotWindows;
using System.Diagnostics;

namespace PortableHotspotWindows.UnitTest
{
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void SerialFileTest()
        {
            SerialKeyIOClass LicenceTest = new SerialKeyIOClass();
            Boolean TestLicence = LicenceTest.ReadLicence();
            Assert.IsFalse(TestLicence);
        }

        [TestMethod]
        public void CMDExecuteTest()
        {
            HotspotClass Hotspot = new HotspotClass();
            ProcessStartInfo psTest = new ProcessStartInfo("cmd.exe");
            psTest.UseShellExecute = false;
            psTest.RedirectStandardOutput = true;
            psTest.CreateNoWindow = true;
            psTest.FileName = "netsh";
            psTest.Arguments = "wlan show hostednetwork";
            Boolean HotspotTest = Hotspot.Execute(psTest);
            Assert.IsTrue(HotspotTest);
        }

        [TestMethod]
        public void CrypgraphyTest()
        {
            String key = "key";
            String PlainText = "PlainText";
            String TestString = CryptographyClass.Decrypt(CryptographyClass.Encrypt(PlainText, key), key);
            Assert.AreEqual(PlainText, TestString);
        }

        [TestMethod]
        public void CrypgraphyLongKeyTest()
        {
            String key = "keykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykeykey";
            String PlainText = "PlainText";
            String TestString = CryptographyClass.Decrypt(CryptographyClass.Encrypt(PlainText, key), key);
            Assert.AreEqual(PlainText, TestString);
        }

        [TestMethod]
        public void ValidSerialKeyTest()
        {
            SerialOperations.Operations opr = new SerialOperations.Operations();
            Boolean CheckValidSerial = opr.VerifyCode("PDA03-OF3IA-56M75-05JN8-TOLES");
            Assert.IsTrue(CheckValidSerial);
        }

        [TestMethod]
        public void InvalidSerialKeyTest()
        {
            SerialOperations.Operations opr = new SerialOperations.Operations();
            Boolean CheckinvalidSerial = opr.VerifyCode("PDA03-OF3IA-56M75-05JN8-TOLRR");
            Assert.IsFalse(CheckinvalidSerial);
        }

        [TestMethod]
        public void NullSerialKeyTest()
        {
            SerialOperations.Operations opr = new SerialOperations.Operations();
            Boolean CheckNullSerial = opr.VerifyCode("");
            Assert.IsFalse(CheckNullSerial);
        }

        [TestMethod]
        public void LongSerialKeyTest()
        {
            SerialOperations.Operations opr = new SerialOperations.Operations();
            Boolean CheckLongSerial = opr.VerifyCode("aiwjdoiajwiodjaoiwjdoiajwdoijaowdjiaoiwjdoiajwdoiajwodijaoiwjdoiajwd");
            Assert.IsFalse(CheckLongSerial);
        }
    }
}
