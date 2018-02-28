using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class MedicalInterpreterModel
    {
        public int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        string PrimaryPhone { get; set; }
        string Email { get; set; }
        string DateOfBirth { get; set; }
        string PreferredName { get; set; }
        string[] Languages { get; set; }
    }
}