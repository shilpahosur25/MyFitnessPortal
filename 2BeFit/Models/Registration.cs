
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace _2BeFit.Models
{

    public class Registration
{
    //public int AutoInc_ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    ///public string DOB { get; set; }
    public string Email { get; set; }
    public int Contact { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    }
}