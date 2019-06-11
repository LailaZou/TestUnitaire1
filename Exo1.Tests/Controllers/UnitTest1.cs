using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exo1.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Exo1.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestSomme()
        {
            FirstController c = new FirstController();
            int nb1 = 10;
            int nb2 = 30;
            int som = 0;
            int valeurAttendue = 40;
            som = c.Somme(nb1, nb2);
            Assert.AreEqual(som, valeurAttendue);
            
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivision()
        {
            FirstController objMath = new FirstController();
            int Result = objMath.Devide(10, 0);
            Assert.AreEqual(10, Result);
        }
        [TestMethod]
        public void TestGetViewWith0()
        {
            FirstController r = new FirstController();
            ViewResult v = r.GetView(0) as ViewResult;
            Assert.AreEqual("View1", v.ViewName);
        }
        [TestMethod]
        public void TestGetViewWithOtherValue()
        {
            FirstController r = new FirstController();
            ViewResult v = r.GetView(1) as ViewResult;
            Assert.AreEqual("View2", v.ViewName);
        }
        [TestMethod]
         public void TestAction2()
        {
            FirstController t = new FirstController();
            ViewResult r = t.Action2() as ViewResult;
            Assert.AreEqual("xxx", r.ViewData["Name"]);
        }
        [TestMethod]
         public void TestDetailsForRedirect()
        {
            FirstController contro = new FirstController();
            var result = contro.Details(-1) as RedirectToRouteResult;
            Assert.AreEqual("Index",result.RouteValues["Action"]);
            Assert.AreEqual("HomeController",result.RouteValues["Controller"]);

        }
        [TestMethod]
         public void TestDetailsForViewResult()
        {
            FirstController contro1 = new FirstController();
            var result1 = contro1.Details(2) as ViewResult;
            Assert.AreEqual("Details",result1.ViewName);

        }

        [TestMethod]
        public void TestSommeCollection()
        {
            List<int> l1 = new List<int> { 1, 2, 3 };
            List<int> l2 = new List<int> { 1, 1, 1 };
            List<int> listPrevu = new List<int> { 2, 3, 4 };
            List<int> listresultant = new List<int>();

            FirstController cont = new FirstController();
            listresultant= cont.SommeCollection(l1, l2);
            CollectionAssert.AreEqual(listPrevu, listresultant);
        }







    }
}
