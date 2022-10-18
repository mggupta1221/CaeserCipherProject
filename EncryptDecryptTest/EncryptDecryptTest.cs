using EncryptDecrypt;

namespace EncryptDecryptTest
{
    [TestClass]
    public class EncryptDecryptTest
    {
        [TestMethod]
        public void TestMethod1()
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
        public void TestMethod2()
        {
            //--Arrange

            EncryptDecrypts e = new EncryptDecrypts("zxUtYr E90 32", 9);
            string expected = "igDcHa N90 32";
            //--Act
            string actual = e.Encrypt();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}