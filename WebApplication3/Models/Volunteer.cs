
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Volunteer
    {
        public string ID { get; set; }
        public enum Category
        {
            NonClinical,
            Interpreter,
            Doctor,
            Nurse
        }

        public string FirstName { get; set; }
        public int LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PrimaryLanguage { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string LicenseNumber { get; set; }
        public string Email { get; set; }
        public bool SubscibeEmail { get; set; }
        public string SecondaryLanguage { get; set; }
        public string HospitalAffiliation { get; set; }
    }
}