using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exo2.Controllers;
using Exo2.Service;


namespace Exo2.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void Testcalcul()
        {
            const int cle = 1;
            var stub = new Stub();

            var x = new Service2Imp(stub);
            var resultat = x.calcul(cle, 3);
            Assert.AreEqual(30, resultat);
        }
        [TestMethod]
        public void TestcalculMock()
        {
            const int cle = 1;
            var m = new Mock();

            var x = new Service2Imp(m);
            var resultat = x.calcul(cle, 3);
            Assert.IsTrue(m.IsCalled);
        }


    }
}
