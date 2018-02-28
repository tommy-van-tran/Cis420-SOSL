using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class EventViewModel
    {
        public int ID { get; set; }
        public string EventSurgery { get; set; }
        public string EventLocation { get; set; }
         public DateTime EventDate { get; set; }
        public ReferAPatientModel Patient { get; set; }
    }
}