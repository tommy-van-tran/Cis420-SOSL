using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class GetInvolvedController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
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

        public ActionResult NonClinical(NonClinicalViewModel viewmodel)
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



            return RedirectToAction("GetInvolved", "GetInvolved");
        }

        public ActionResult Physician(PhysicianViewModel viewModel)
        {
            var Physician = new PhysicianModel()
            {
                Id = viewModel.Id,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Address = viewModel.Address,
                City = viewModel.City,
                State = viewModel.State,
                ZipCode = viewModel.ZipCode,
                PrimaryPhone = viewModel.PrimaryPhone,
                Email = viewModel.Email,
                DateOfBirth = viewModel.DateOfBirth,
                MedicalSpecialty = viewModel.MedicalSpecialty,
                StateChoice = viewModel.StateChoice,
                ProfessionalLicenseNumber = viewModel.ProfessionalLicenseNumber,
                ProfessionalAlmaMater = viewModel.ProfessionalAlmaMater,
                GraduationYear = viewModel.GraduationYear,
            };

            db.Physicians.Add(Physician);

            db.SaveChanges();

            return RedirectToAction("GetInvolved", "GetInvolved");

        }

        public ActionResult NonPhysicianClinical(NonPhysicianClinicalViewModel viewModel)
        {
            var NonPhysicianClinical = new NonPhysicianClinicalModel()
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Address = viewModel.Address,
                City = viewModel.City,
                State = viewModel.State,
                PostalCode = viewModel.PostalCode,
                PhoneNumber = viewModel.PhoneNumber,
                Email = viewModel.Email,
                Birthday = viewModel.Birthday,
                SurgicalTechnician = viewModel.SurgicalTechnician,
                ProfessionalLicenseNumber=viewModel.ProfessionalLicenseNumber,
                CRNA = viewModel.CRNA,
                RN = viewModel.RN,
                CNA = viewModel.CNA,
                PCA = viewModel.PCA,
                PA = viewModel.PA,
                EMT = viewModel.EMT,
                COA = viewModel.COA,
                COT = viewModel.COT,
                APRN = viewModel.APRN,
                Other = viewModel.Other,
                NotApplicable = viewModel.NotApplicable,
                StateChoice = viewModel.StateChoice,
                PreOp = viewModel.PreOp,
                PACU = viewModel.PACU,
                Circulation = viewModel.Circulation,
                Surgery = viewModel.Surgery,
                Recovery = viewModel.Recovery,
                TShirtSize = viewModel.TShirtSize


            };

            db.NonPhysicianClinicals.Add(NonPhysicianClinical);

            db.SaveChanges();

            return RedirectToAction("GetInvolved", "GetInvolved");

        }


       public ActionResult MedicalInterpreter(MedicalInterpreterViewModel viewModel)
        {
            var MedicalInterpreter = new MedicalInterpreterModel()
            {
               
            ID = viewModel.ID,
            FirstName = viewModel.FirstName,
            LastName = viewModel.LastName,
            Address = viewModel.Address,
            City = viewModel.City,
            State = viewModel.State,
            ZipCode = viewModel.ZipCode, 
            PrimaryPhone = viewModel.PrimaryPhone,
            Email = viewModel.Email,
            DateOfBirth = viewModel.DateOfBirth, 
            PreferredName = viewModel.PreferredName, 
            Spanish = viewModel.Spanish,
            Arabic = viewModel.Arabic,
            Hindi = viewModel.Hindi,
            Other = viewModel.Other

            };
            db.MedicalInterpreters.Add(MedicalInterpreter);

            db.SaveChanges();

            return RedirectToAction("GetInvolved", "GetInvolved");



        }


        public ActionResult VolunteerComment()
        {
            return View();
        }
    }
}