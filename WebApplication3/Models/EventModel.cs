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
        DateTime EventDate { get; set; }
        ReferAPatientModel Patient { get; set; }
        MedicalInterpreterModel[] Interpreter { get; set; }
        NonPhysicianClinicalVolunteerModel[] ClinicalVolunteer{get;set;}
        NonClinicalGeneralVolunteerModel[] NonClinicalVolunteer { get; set; }
        PhysicianVolunteerModel[] Physician { get; set; }



    }
}