
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVMLibrary;

namespace TVMTests
{
    [TestClass]
    public class FVTest
    {
        [DataRow(100, 0.1, 1, 110)]
        [DataRow(100, 0.1, 2, 121)]
        [DataRow(-100, 0.1, 1, -110)]
        [DataRow(0, 0.1, 1, 0)]
        [DataRow(321, 0.4, 3, 880.82)]
        [DataTestMethod]
        public void SimpleFVTest(double startValue, double rate, int periods, double endValue)
        {
            FV target = new FV(startValue, rate, periods);
            Assert.AreEqual(endValue, target.EndValue, 0.01);
        }

        [TestMethod]
        public void FVMakeChangesTest()
        {
            FV target = new FV(100, 0.1, 1);
            Assert.AreEqual(110, target.EndValue, 0.01);
            target.Periods = 2;
            Assert.AreEqual(121, target.EndValue, 0.01);

        }
    }
}
