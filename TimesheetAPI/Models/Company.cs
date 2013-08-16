using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimesheetAPI.Models
{
    public class Company : Entity
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CompanyURL { get; set; }
        public string LogoURL { get; set; }

    }
}