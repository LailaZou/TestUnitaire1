using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exo1.Controllers
{
    public class FirstController : Controller
    {
       
        // GET: test
        public ActionResult Index()
        {
            return View();
        }

        public int Somme(int nb1, int nb2)
        {
            return nb1 + nb2;
        }

        public ActionResult Action2()
        {
            ViewData["Name"] = "xxx";
            return View();
        }
        public ActionResult Details(int id)
        {
            if (id < 1)
                return RedirectToAction("Index", "HomeController");
            return View("Details");
        }
        public ActionResult GetView(int id)
        {
            if (id == 0)
                return View("View1");
            else
                return View("View2");
        }

        public int Devide(int a, int b)
        {
            return a / b;
        }

        public List<int> SommeCollection(List<int> l1, List<int> l2)
        {
            List<int> somList = new List<int>();
            if (l1.Count == l2.Count)
            {
                for (int i = 0; i < l1.Count; i++)
                    somList.Add(l1[i] + l2[i]);

            }
            return somList;
        }
    }
}