using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_for_2_3A
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int[] a = { 2, 2, 0, 3, 4 };
            int result = Lab2_3A.Program.Mi_P(a, n);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int n = 3;
            int[] a = { 2, 2, 0, 3, 4 };
            int result = Lab2_3A.Program.Dob_P(a, n);
            Assert.AreEqual(4, result);
        }
    }
}
