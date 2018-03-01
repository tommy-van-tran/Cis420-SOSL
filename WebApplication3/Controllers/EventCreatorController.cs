using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EventCreatorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EventCreator
        public ActionResult EventCreator()
        {
            return View();
        }



        public ActionResult Event(EventViewModel viewmodel)
        {
            var Event = new EventModel()
            {
                ID = viewmodel.ID,
                EventSurgery = viewmodel.EventSurgery,
                EventLocation = viewmodel.EventLocation,
                EventDate = viewmodel.EventDate,


            };
            db.EventModels.Add(Event);

            db.SaveChanges();



            return RedirectToAction("GetInvolved", "GetInvolved");
        }
    }
}