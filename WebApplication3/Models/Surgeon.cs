
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Surgeon : Doctor
    {
        public string SurgeonID { get; set; }
        public string SurgeonSpecialty { get; set; }
    }
}