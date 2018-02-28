using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }


    public ActionResult EventCreator(EventViewModel viewmodel)
    {
        var NonClinical = new NonClinicalModel()
        {
            Id = viewmodel.Id,
            FirstName = viewmodel.FirstName,
            LastName = viewmodel.LastName,
            Email = viewmodel.Email,
            Address = viewmodel.Address,
            City = viewmodel.City,
            State = viewmodel.State,
            PostalCode = viewmodel.PostalCode,
            PhoneNumber = viewmodel.PhoneNumber,
            Birthday = viewmodel.Birthday,
            PreferredName = viewmodel.PreferredName,
            Employer = viewmodel.Employer,
            BestDescription = viewmodel.BestDescription,
            Registration = viewmodel.Registration,
            Cleaning = viewmodel.Cleaning,
            ClinicalShadowing = viewmodel.ClinicalShadowing,
            Fundraising = viewmodel.Fundraising,
            WhyInterested = viewmodel.WhyInterested,
            TShirtSize = viewmodel.TShirtSize
        };
        db.NonClinicals.Add(NonClinical);

        db.SaveChanges();



        return RedirectToAction("Index", "Home");
    }
}