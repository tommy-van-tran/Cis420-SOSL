using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class EventModel
    {
        public int ID { get; set; }
        string EventSurgery { get; set; }
        string EventLocation { get; set; }
        string EventDate { get; set; }
        ReferAPatientModel Patient { get; set; }

    }
}