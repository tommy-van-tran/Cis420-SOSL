using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class CommentFormModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        DateTime ServiceDate { get; set; }
        string Feedback { get; set; }
    }
}