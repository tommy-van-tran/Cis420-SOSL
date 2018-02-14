﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class PhysicianVolunteerModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        string PrimaryPhone { get; set; }
        string Email { get; set; }
        DateTime DateOfBirth { get; set; }
        string MedicalSpecialty { get; set; }
        string[] StatesLicensedIn { get; set; }
        string ProfessionalLicenseNumber { get; set; }
        string ProfessionalAlmaMater { get; set; }
        string GraduationYear { get; set; }
        //possibly figure out how to upload file
        
    }
}