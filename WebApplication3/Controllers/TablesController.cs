using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class TablesController : Controller
    { private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Tables
        public ActionResult Tables()
        {
            var eventModels = db.EventModels.ToList();
            ViewBag.EventModels = eventModels;
            var nonClinical = db.NonClinicals.ToList();
            ViewBag.NonClinicals = nonClinical;
            return View();
        }
    }
}