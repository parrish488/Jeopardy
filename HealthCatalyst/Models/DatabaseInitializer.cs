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
                new Subscriber {FirstName="Jane", LastName="Doe", Street="123 Second Street", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2001, 7, 1), Interests = "Cooking" },
                new Subscriber {FirstName="Harry", LastName="Potter", Street="4 Privet Drive", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2002, 7, 1), Interests = "Wizarding", ImagePath = "harry_potter.jpg" },
                new Subscriber {FirstName="Ronald", LastName="Weasley", Street="The Burrow", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2003, 7, 1), Interests = "Wizarding", ImagePath = "ronald_weasley.jpg" },
                new Subscriber {FirstName="Hermione", LastName="Granger", Street="Middle London", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2004, 7, 1), Interests = "Wizarding", ImagePath = "hermione_granger.jpg" },
                new Subscriber {FirstName="Albus", LastName="Dumbledore", Street="Hogwarts", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2005, 7, 1), Interests = "Wizarding", ImagePath = "albus_dumbledore.jpg" },
                new Subscriber {FirstName="Ginny", LastName="Weasley", Street="The Burrow", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2006, 7, 1), Interests = "Wizarding", ImagePath = "ginny_weasley.jpg" },
                new Subscriber {FirstName="Dudley", LastName="Dursley", Street="4 Privet Drive", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2007, 7, 1), Interests = "Wizarding", ImagePath = "dudley_dursley.jpg" },
                new Subscriber {FirstName="Sirius", LastName="Black", Street="12 Grimmauld Pl.", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2008, 7, 1), Interests = "Wizarding", ImagePath = "sirius_black.jpg" },
                new Subscriber {FirstName="Rubeus", LastName="Hagrid", Street="Hagrid's Hut", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2009, 7, 1), Interests = "Wizarding", ImagePath = "rubeus_hagrid.jpg" },
                new Subscriber {FirstName="Draco", LastName="Malfoy", Street="Malfoy Mannor", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2010, 7, 1), Interests = "Wizarding", ImagePath = "draco_malfoy.jpg" },
                new Subscriber {FirstName="Gilderoy", LastName="Lockhart", Street="St. Mungo's", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2011, 7, 1), Interests = "Wizarding", ImagePath = "gilderoy_lockhart.jpg" },
                new Subscriber {FirstName="Severus", LastName="Snape", Street="Spinner's End", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2012, 7, 1), Interests = "Wizarding", ImagePath = "severus_snape.png" },
           };

            context.Subscribers.AddRange(clients);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}