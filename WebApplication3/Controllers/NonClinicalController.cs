using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class NonClinicalController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GeneralVolunteerFormController
        public ActionResult Index()
        {

            return View(new NonClinicalViewModel());
        }

        public ActionResult Index(NonClinicalViewModel viewmodel)
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
}