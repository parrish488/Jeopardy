using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthCatalyst;
using HealthCatalyst.Controllers;

namespace HealthCatalyst.Tests.Controllers
{
    [TestClass]
    public class SubscribersControllerTest
    {
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
    }
}
