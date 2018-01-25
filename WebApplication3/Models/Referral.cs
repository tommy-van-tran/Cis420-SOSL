
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Referral : Doctor
    {
        public string SurgeryType { get; set; }
        public string Name { get; set; }
        public string DoctorReferralCode { get; set; }

    }
}