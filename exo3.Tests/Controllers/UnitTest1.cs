using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using exo3.Repositories;
using exo3.Controllers;
using NSubstitute;
using System.Web.Mvc;
using System.Collections.Generic;
using exo3.Models;
using System.Collections;

namespace exo3.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        IEtudiantRepository _stubMock;

        public UnitTest1()
        {
            _stubMock = Substitute.For<IEtudiantRepository>();

        }
       
        [TestMethod]
        public void TestIndex()
        {
            EtudiantController contro = new EtudiantController(_stubMock);
            ViewResult r = contro.Index() as ViewResult;
            Assert.AreEqual("exo3.Controllers.EtudiantController", r.ViewData["ControllerName"]);

            Assert.AreEqual("Index", r.ViewName);

            Assert.IsNotNull(r.ViewData.Model);
            Assert.AreEqual(r.ViewData.Model,_stubMock.GetAllEtudiant() );
            
             //   IsType<IEtudiantRepository>(r.ViewData.Model);
            //  Assert.AreEqual( r.ViewData.Model,"Etudiant");
        }
        [TestMethod]
        public void TestIndexIsCalled()
        {
            EtudiantController contro = new EtudiantController(_stubMock);

            var resultat = contro.Index();
            _stubMock.Received().GetAllEtudiant();// tester si Getdonnee a ete appele

        }

        [TestMethod]
        public void TestCreateForRedirect()
        {
            EtudiantController contro = new EtudiantController(_stubMock);
            etudiant et = new etudiant();
            
            
            var result = contro.Create(et) as RedirectToRouteResult;

            Assert.AreEqual("Index", result.RouteValues["Action"]);

        }

        [TestMethod]
        public void TestCreateIsCalled()
        {
            EtudiantController contro = new EtudiantController(_stubMock);

            etudiant et = new etudiant();


            var result = contro.Create(et);
            _stubMock.Received().CreateNewEtudiant(et);// tester si Getdonnee a ete appele

        }
    }
}
