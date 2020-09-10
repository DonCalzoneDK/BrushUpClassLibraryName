using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryName;

namespace UnitTestProjectName
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMyNameIs()
        {

            //Arrange
            Name name = new Name("Josh");

            //Act
            string actualName = name.MyNameIs();
            //Assert
            Assert.AreEqual("My name is Josh", actualName);
        }
    }
}
