using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using TimesheetAPI.Models;

namespace TimesheetAPI.Services
{
    public class CompanyService : MongoDBContext
    {
        private MongoCollection<Company> Companies;

        public CompanyService()
        {
            Companies = Database.GetCollection<Company>("Companies");
        }

        public List<Company> GetCompanies()
        {
             
            List<Company> lstCompanies = new List<Company>();

            MongoCursor<Company> cursor = Companies.FindAll();

            lstCompanies = cursor.ToList<Company>();

            return lstCompanies;
        }

        public void Add(Company company)
        {
            Companies.Insert(company);
        }
    }
}