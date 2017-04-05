using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HealthCatalyst.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var clients = new List<Subscriber>
            {
                new Subscriber {FirstName="John", LastName="Doe", Street="123 First Street", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2000, 1, 1), Interests = "Outoors" },
                new Subscriber {FirstName="Jane", LastName="Doe", Street="123 Second Street", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2000, 7, 1), Interests = "Cooking" }
            };

            context.Subscribers.AddRange(clients);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}