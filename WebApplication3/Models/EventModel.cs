using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class EventModel
    {
        string EventSurgery { get; set; }
        string EventLocation { get; set; }
        DateTime EventDate { get; set; }
        ReferAPatientModel Patient { get; set; }

    }
}