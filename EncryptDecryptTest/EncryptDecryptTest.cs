using EncryptDecrypt;

namespace EncryptDecryptTest
{
    [TestClass]
    public class EncryptDecryptTest
    {
        [TestMethod]
        public void EncryptTestMethod1()
        {
            //--Arrange

            EncryptDecrypts e = new EncryptDecrypts("abs123Utb",3);
            string expected = "dev123Xwe";
            //--Act
            string actual = e.Encrypt();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncryptTestMethod2()
        {
            //--Arrange

            EncryptDecrypts e = new EncryptDecrypts("zxUtYr E90 32", 9);
            string expected = "igDcHa N90 32";
            //--Act
            string actual = e.Encrypt();
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DecryptTestMethod1()
        {
            //--Arrange

            EncryptDecrypts e = new EncryptDecrypts("zxUtYr E90 32", 9);
            string expected = "qoLkPi V90 32";
            //--Act
            string actual = e.Decrypt();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}