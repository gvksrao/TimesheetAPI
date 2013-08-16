using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using System.Configuration;

namespace TimesheetAPI.Services
{
    public abstract class MongoDBContext
    {
        public MongoDatabase Database
        {
            get
            {
                return MongoDatabase.Create(GetMongoDbConnectionString());
            }
        }

        private string GetMongoDbConnectionString()
        {
            string value = ConfigurationManager.AppSettings.Get("MONGOHQ_URL") ??
                ConfigurationManager.AppSettings.Get("MONGOLAB_URI") ??
                "mongodb://somesh:somesh@ds037768.mongolab.com:37768/someshdb";

            return value;
        }

        public void GetMongoCollection(string collectionName)
        {
            //MongoCollection<T> Companies = Database.GetCollection<T>(collectionName);
        }

    }
}