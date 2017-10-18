using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KovatsNorbertModulzaroSzf17;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HowManyPatient()
        {
            var sum = patientSum(
                new[]
                {
                    new Patient{ Name="Valami János"},
                    new Patient{ Name="Valami Edina"},
                    new Patient{ Name="Valami Lajos"},
                    new Patient{ Name="Valami Krisztina"},
                    new Patient{ Name="Valami Anna"}
                }
                );
            Assert.AreEqual(5, sum);
        }

    }
}
