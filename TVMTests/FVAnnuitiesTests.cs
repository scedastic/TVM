using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVMLibrary;

namespace TVMTests
{
    [TestClass]
    public class FVAnnuitiesTests
    {
        [DataRow(1000, 0.05, 1, 1000.00)]
        [DataRow(1000, 0.05, 2, 2050.00)]
        [DataRow(1000, 0.05, 5, 5525.63)]
        [DataTestMethod]
        public void SimpleFVATest(double cashFlow, double rate, int periods, double endValue)
        {
            FVAnnuity fv = new FVAnnuity(cashFlow, rate, periods);
            Assert.AreEqual(endValue, fv.EndValue, 0.01);

        }

    }
}
