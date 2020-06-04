using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_lab_5_17_3;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("iiiiiii", new Worker().UkrainianI("³³³³³³³"));
        }
    }
}
