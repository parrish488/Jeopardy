using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthCatalyst;
using HealthCatalyst.Controllers;
using System.Data.Entity;
using HealthCatalyst.Models;

namespace HealthCatalyst.Tests.Controllers
{
    [TestClass]
    public class SubscribersControllerTest
    {
        [TestInitialize]
        public void TestSetup()
        {
            DatabaseContext db = new DatabaseContext();
            db.Subscribers.Add(GetTestSubscriber());
            db.SaveChanges();
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            SubscribersController controller = new SubscribersController();

            // Act
            ViewResult result = controller.Index(string.Empty, string.Empty, string.Empty, 1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            SubscribersController controller = new SubscribersController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Details()
        {
            // Arrange
            SubscribersController controller = new SubscribersController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            SubscribersController controller = new SubscribersController();

            // Act
            ViewResult result = controller.Delete(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        public Subscriber GetTestSubscriber()
        {
            return new Subscriber { FirstName = "John", LastName = "Doe", Street = "123 First Street", City = "Nowhere", State = "UT", Zip = "84000", Birthdate = new DateTime(2000, 1, 1), Interests = "Outoors" };
        }
    }
}
