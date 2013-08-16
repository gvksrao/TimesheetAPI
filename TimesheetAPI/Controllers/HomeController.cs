using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimesheetAPI.Models;

namespace TimesheetAPI.Controllers
{
    public class HomeController : Controller
    {
        private List<Company> companies = new List<Company>
        {
            //new Company { id=1, Name = "Wipro", Description="Wipro Company Name", LogoURL="www.wipro.com"},
            //new Company { id=2, Name = "CSC", Description="CSC Company Name", LogoURL="www.csc.com"},
            //new Company { id=3, Name = "RelQ", Description="RelQ Company Name", LogoURL="www.relq.com"}
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CompanyView()
        {

            return View(companies);
        }

    }
}
