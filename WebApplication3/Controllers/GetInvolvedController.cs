using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class GetInvolvedController : Controller
    {
        // GET: GetInvolved
        public ActionResult GetInvolved()
        {
            return View();
        }
        
        public ActionResult PhysicianForm()
        {
            return View();
        }

        public ActionResult NonClinicalForm()
        {
            return View();
        }

        public ActionResult InterpreterForm()
        {
            return View();

        }

        public ActionResult NonPhysicianClinicalForm()
        {
            return View();
        }
        public ActionResult VolunteerComment()
        {
            return View();
        }
    }
}