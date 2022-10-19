using CaeserCipherAlgorithm;

namespace EncryptDecryptTest
{
    [TestClass]
    public class EncryptDecryptTest
    {
        [TestMethod]
        public void EncryptTestTextFactor3()
        {
            //--Arrange

            CaeserCipher obj = new CaeserCipher();
            string expected = "dev123Xwe";
            //--Act
            string actual = obj.DoCeaserCipher("abs123Utb", 3);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncryptTest()
        {
            //--Arrange

            CaeserCipher obj = new CaeserCipher();
            string expected = "igDcHa N90 32";
            //--Act
            string actual = obj.DoCeaserCipher("zxUtYr E90 32", 9);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DecryptTestMethod1()
        {
            //--Arrange

            CaeserCipher obj = new CaeserCipher();
            string expected = "qoLkPi V90 32";
            //--Act
            string actual = obj.DoCeaserCipher("zxUtYr E90 32", -9);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}