using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{

    public class NonPhysicianClinicalVolunteerModel
    {
        public int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        string PrimaryPhone { get; set; }
        string Email { get; set; }
        DateTime DateOfBirth { get; set; }
        string[] ProfessionalTitles { get; set; }
        string[] StatesLicensedIn { get; set; }
        string ProfessionalLicenseNumber { get; set; }
        string[] AreaOfSpecialty { get; set; }
        string ShirtSize { get;set; }
    }
}