using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCatalyst.Models
{
    public class Subscriber
    {
        public Subscriber()
        {
        }

        [Display(Name = "Subscriber")]
        public int SubscriberID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
        public DateTime Birthdate { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [DataType(DataType.MultilineText)]
        public string Interests { get; set; }
        public string ImagePath { get; set; }
    }
}