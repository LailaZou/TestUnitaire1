using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exo2.Controllers;
using Exo2.Service;
using NSubstitute;

namespace Exo2.Tests.Controllers
{
    [TestClass]
    public class UnitTest2
    {
        IService1 _stub;

        public UnitTest2()
        {
            _stub = Substitute.For<IService1>();
        }

        [TestMethod]
        public void Testcalcul()
        {
            const int cle = 1;
            _stub.GetDonnee(cle).Returns(10);// set a return value

            var x = new Service2Imp(_stub);
            var resultat = x.calcul(cle, 3);
            Assert.AreEqual(30, resultat);
        }

        [TestMethod]
        public void TestcalculMock()
        {
            const int cle = 1;

            var x = new Service2Imp(_stub);
            var resultat = x.calcul(cle, 3);
            _stub.Received().GetDonnee(cle);// tester si Getdonnee a ete appele
        }
    }
}
