using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Doctor:Volunteer
    {
        public string MedicalID { get; set; }
        public string Specialty { get; set; }
        public string ReferalCode { get; set; }
    }
}