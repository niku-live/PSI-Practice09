using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd;

namespace TestProject
{
    [TestClass]
    public class LogicUnitTest
    {
        [TestMethod]
        public void TestGetFirstEmployeeName()
        {
            var logic = new Logic();
            var expected = "Jonas";
            var actual = logic.GetFirstEmployeeName();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetLastEmployeeName()
        {
            var logic = new Logic();
            var expected = "Jonas";
            var actual = logic.GetLastEmployeeName();
            Assert.AreEqual(expected, actual);
        }
    }
}
