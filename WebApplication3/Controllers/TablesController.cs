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
            var eventModels = db.EventModels.OrderByDescending<EventModel,int>(e => e.ID).ToList();
            
            ViewBag.EventModels = eventModels;

            var nonClinical = db.NonClinicals.OrderByDescending<NonClinicalModel,int>(e=>e.Id).ToList();
            ViewBag.NonClinicals = nonClinical;

            var nonPhysicianClinical = db.NonPhysicianClinicals.OrderByDescending<NonPhysicianClinicalModel, int>(e => e.ID).ToList();
            ViewBag.NonPhyiscianClinicals = nonPhysicianClinical;

            var physician = db.Physicians.OrderByDescending<PhysicianModel, int>(e => e.Id).ToList();
            ViewBag.Physicians = physician;

            var interpreter = db.MedicalInterpreters.OrderByDescending<MedicalInterpreterModel, int>(e => e.ID).ToList();
            ViewBag.MedicalInterpreters = interpreter;
            return View();
        }
    }
}