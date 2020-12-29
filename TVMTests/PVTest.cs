
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVMLibrary;

namespace TVMTests
{
    [TestClass]
    public class PVTest
    {
        [DataRow(100, 0.1, 1, 110)]
        [DataRow(100, 0.1, 2, 121)]
        [DataRow(-100, 0.1, 1, -110)]
        [DataRow(0, 0.1, 1, 0)]
        [DataRow(321, 0.4, 3, 880.824)]
        [DataTestMethod]
        public void SimplePVTest(double startValue, double rate, int periods, double endValue)
        {
            PV target = new PV(endValue, rate, periods);
            Assert.AreEqual(startValue, target.StartValue, 0.01);
        }

        [TestMethod]
        public void PVMakeChangesTest()
        {
            PV target = new PV(110, 0.1, 1);
            Assert.AreEqual(100, target.StartValue, 0.01);
            target.EndValue = 121;
            target.Periods = 2;
            Assert.AreEqual(100, target.StartValue, 0.01);
        }
    }
}
