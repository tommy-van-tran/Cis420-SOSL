
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Nurse : Volunteer
    {
        public string NurseID { get; set; }
        public string Specialty { get; set; }
    }
}