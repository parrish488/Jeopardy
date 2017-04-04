using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HealthCatalyst.Models
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var clients = new List<Client>
            {
                new Client {FirstName="John", LastName="Doe", Street="123 First Street", City="Nowhere", State="UT", Zip="84000", PrimaryPhone="(801) 888-8888", Email="john_doe@gmail.com" },
                new Client {FirstName="Jane", LastName="Doe", Street="123 Second Street", City="Nowhere", State="UT", Zip="84000", PrimaryPhone="(801) 888-8888", Email="jane_doe@gmail.com" }
            };

            context.Clients.AddRange(clients);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}