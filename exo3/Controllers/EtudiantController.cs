using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using exo3.Models;
using exo3.Repositories;

namespace exo3.Controllers
{
    public class EtudiantController : Controller
    {
        IEtudiantRepository rep;

       public EtudiantController(IEtudiantRepository repository)
        {
            rep = repository;
        }
        // GET: Etudiant
        public ActionResult Index()
        {
            ViewData["ControllerName"] = this.ToString();
            return View("Index",rep.GetAllEtudiant());
        }
        public ActionResult Create(etudiant et)
        {
            if (ModelState.IsValid)
            {
                rep.CreateNewEtudiant(et);
                return RedirectToAction("Index");
            }
            return View("Create");
        }


    }
}