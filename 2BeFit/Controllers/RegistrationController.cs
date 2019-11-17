using _2befit.Models;
using _2BeFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2BeFit.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
             [HttpPost]
        public ActionResult Index(Registration obj)

        {
           // if (ModelState.IsValid)
            {
                RegistrationDBEntities db = new RegistrationDBEntities();
                db.Registartion.Add(obj);
                db.SaveChanges();
            }          
            return View(obj);
        }
    }
}