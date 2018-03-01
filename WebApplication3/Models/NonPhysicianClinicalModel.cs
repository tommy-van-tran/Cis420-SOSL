using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{

    public class NonPhysicianClinicalModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string StateChoice { get; set; }
        public string ProfessionalLicenseNumber { get; set; }
        public string TShirtSize { get; set; }
        public bool SurgicalTechnician { get; set; }
        public bool CRNA { get; set; }
        public bool RN { get; set; }
        public bool CNA { get; set; }
        public bool PCA { get; set; }
        public bool PA { get; set; }
        public bool EMT { get; set; }
        public bool COA { get; set; }
        public bool COT { get; set; }
        public bool APRN { get; set; }
        public bool Other { get; set; }
        public bool NotApplicable { get; set; }
        public bool PreOp { get; set; }
        public bool PACU { get; set; }
        public bool Circulation { get; set; }
        public bool Surgery { get; set; }
        public bool Recovery { get; set; }
    }
}