using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTests_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Discriminator_Grab()
        {
            DBContext db = new DBContext();

            Assert.AreEqual("ClassLibrary.Admin", BusinessLayer.GetUserDiscriminator(1));
        }
    }
}
