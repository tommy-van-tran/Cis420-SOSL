using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Models
{

    public class NonPhysicianClinicalViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string ProfessionalTitles { get; set; }
        public string StateLicensedIn { get; set; }
        public string ProfessionalLicenseNumber { get; set; }
        public string AreaOfSpecialty { get; set; }
        public string TShirtSize { get; set; }
    }
}