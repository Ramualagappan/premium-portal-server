using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using Portal.Model;
using Portal.services;
using PremiumCalculator.Controllers;
using System;
using System.Web.Http.Results;

namespace Portal.WebApi.Tests
{
    public class PremiumCalculatorControllerTest
    {
        //private Mock<IPortalServices> _portalServices;
        //private PremiumCalculatorController _premiumCalculatorController;

        [SetUp]
        public void Setup()
        {
            // ILogger<PremiumCalculatorController> logger;
            //_portalServices = new Mock<IPortalServices>(MockBehavior.Default);
            //_premiumCalculatorController = new PremiumCalculatorController(_portalServices.Object);
        }

        [Test]
        public void CalculatePremium()
        {
            UserDetails userDetails = new UserDetails();
            userDetails.Age = 32;
            userDetails.Deathsuminsured = 5000;
            userDetails.Name = "Test Users";
            userDetails.DOB = DateTime.Now.AddYears(-32);
            userDetails.Occupation = "Professional";

            PortalServices portalServices = new PortalServices();
            var totalPremium = portalServices.CalculatePremium(userDetails);

            Assert.Equals(totalPremium, 1920);
        }
    }
}