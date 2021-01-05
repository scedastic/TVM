using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVMLibrary;

namespace TVMTests
{
    [TestClass]
    public class PVAnnuitiesTests
    {
        [DataRow(1000, 0.05, 1, 952.38)]
        [DataRow(1000, 0.05, 2, 1859.41)]
        [DataRow(1000, 0.05, 3, 2723.25)]
        [DataRow(1000, 0.05, 4, 3545.95)]
        [DataRow(1000, 0.05, 5, 4329.48)]
        [DataTestMethod]
        public void SimplePVATest(double cashFlow, double rate, int periods, double startValue)
        {
            PVAnnuity pv = new PVAnnuity(cashFlow, rate, periods);
            Assert.AreEqual(startValue, pv.StartValue, 0.01);
        }

    }
}
