using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    [Authorize]
    public class LandingPageController : Controller
    {
        // GET: LandingPage
        public ActionResult LandingPage()
        {
            return View();
        }
    }
}