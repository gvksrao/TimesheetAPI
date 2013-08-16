using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimesheetAPI.Models;
using TimesheetAPI.Services;

namespace TimesheetAPI.Controllers
{
    public class CompanyController : ApiController
    {
        CompanyService companyService = new CompanyService();
        private static List<Company> companies = new List<Company>
        {
            //new Company { id=1, Name = "Wipro", Description="Wipro Company Name", LogoURL="www.wipro.com"},
            //new Company { id=2, Name = "CSC", Description="CSC Company Name", LogoURL="www.csc.com"},
            //new Company { id=3, Name = "RelQ", Description="RelQ Company Name", LogoURL="www.relq.com"}
        };

        public IEnumerable<Company> GetAllCompanies()
        {

            return companyService.GetCompanies();
            //return companies;
        }

        //public Company GetCompany(int id)
        //{
        //    var company = companies.FirstOrDefault((p) => p.id == id);

        //    if (company == null)
        //    {
        //        return new Company();
        //        //throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound,"Company not exists"));
        //    }
        //    return company;

        //}

        public HttpResponseMessage PostCompany(Company company)
        {
            HttpResponseMessage response;
            Company comp = new Company();
            if (ModelState.IsValid)
            {
                if (company != null)
                {
                    //comp = GetCompany(company.id);
                    if (comp.Description == null)
                    {
                        companyService.Add(company);
                        response = Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                        response = Request.CreateResponse(HttpStatusCode.InternalServerError, "Duplicate Company");

                }

                else
                    response = Request.CreateResponse(HttpStatusCode.InternalServerError, "Invalid Payload");

            }
            else
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, " Modal state is invalid");

            return response;
        }
        public void PutCompany(Company company)
        {
            //int index = companies.FindIndex(p => p.id == company.id);
            //if (index == -1)
            //    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound, "Invalid or company not exists"));
            //else
            //{
            //    companies.RemoveAt(index);
            //    companies.Add(company);
            //}
            
        }
        public void DeleteCompany(int id)
        {
            //Company item = GetCompany(id);
            //if (item == null)
            //{
            //    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound, "Company not exists"));
            //}

            //companies.Remove(item);
        }

    }
}
