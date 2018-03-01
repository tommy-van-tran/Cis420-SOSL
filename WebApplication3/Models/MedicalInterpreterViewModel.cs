using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class MedicalInterpreterViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PrimaryPhone { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string PreferredName { get; set; }
        public bool Spanish { get; set; }
        public bool Arabic { get; set; }
        public bool Hindi { get; set; }
        public bool Other { get; set; }
    }
}