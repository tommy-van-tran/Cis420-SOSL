
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Referal : Doctor
    {
        public string SurgeryType { get; set; }
        public string Name { get; set; }
        public string DoctorReferalCode { get; set; }

    }
}