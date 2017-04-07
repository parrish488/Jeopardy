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
                new Subscriber {FirstName="Harry", LastName="Potter", Street="4 Privet Drive", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2002, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Ronald", LastName="Weasley", Street="The Burrow", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2003, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Hermione", LastName="Granger", Street="Middle London", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2004, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Albus", LastName="Dumbledore", Street="Hogwarts", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2005, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Ginny", LastName="Weasley", Street="The Burrow", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2006, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Dudley", LastName="Dursley", Street="4 Privet Drive", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2007, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Sirius", LastName="Black", Street="12 Grimmauld Pl.", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2008, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Rubius", LastName="Hagrid", Street="Hagrid's Hut", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2009, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Draco", LastName="Malfoy", Street="Malfoy Mannor", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2010, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Gilderoy", LastName="Lockhart", Street="St. Mungo's", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2011, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Severus", LastName="Snape", Street="Spinner's End", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2012, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="Lily", LastName="Potter", Street="Godric's Hollow", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2013, 7, 1), Interests = "Wizarding" },
                new Subscriber {FirstName="James", LastName="Potter", Street="Godric's Hollow", City="Nowhere", State="UT", Zip="84000", Birthdate = new DateTime(2014, 7, 1), Interests = "Wizarding" }
            };

            context.Subscribers.AddRange(clients);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}