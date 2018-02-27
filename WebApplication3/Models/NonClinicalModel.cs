using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class NonClinicalModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public int PhoneNumber { get; set; }
        public string Birthday { get; set; }
        public string PreferredName { get; set; }
        public string Employer { get; set; }
        public string BestDescription { get; set; }
        public bool Registration { get; set; }
        public bool Cleaning { get; set; }
        public bool ClinicalShadowing { get; set; }
        public bool Fundraising { get; set; }
        public string WhyInterested { get; set; }
        public string TShirtSize { get; set; }

    }
}