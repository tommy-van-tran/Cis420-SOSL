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
        public string ZipCode { get; set; }
        public string PrimaryPhone { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string[] ProfessionalTitles { get; set; }
        public string[] StatesLicensedIn { get; set; }
        public string ProfessionalLicenseNumber { get; set; }
        public string[] AreaOfSpecialty { get; set; }
        public string ShirtSize { get; set; }
    }
}