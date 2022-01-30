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
        public void CalculatePremium_Positive()
        {
            UserDetails userDetails = new UserDetails();
            userDetails.Age = 32;
            userDetails.Deathsuminsured = 5000;
            userDetails.Name = "Test Users";
            userDetails.DOB = DateTime.Now.AddYears(-32);
            userDetails.Occupation = "Professional";

            PortalServices portalServices = new PortalServices();
            var totalPremium = portalServices.CalculatePremium(userDetails);

            Assert.AreEqual(totalPremium, 1920);
        }
        [Test]
        public void CalculatePremium_Negative()
        {
            UserDetails userDetails = new UserDetails();
            userDetails.Age = 32;
            userDetails.Deathsuminsured = 5000;
            userDetails.Name = "Test Users";
            userDetails.DOB = DateTime.Now.AddYears(-32);
            userDetails.Occupation = "Professional";

            PortalServices portalServices = new PortalServices();
            var totalPremium = portalServices.CalculatePremium(userDetails);

            Assert.AreNotEqual(totalPremium, 1921);
        }

        [Test]
        public void GetOccupationDetails()
        {
             
            PortalServices portalServices = new PortalServices();
            var lstOccupationDetail = portalServices.GetOccupationDetails();

            Assert.IsTrue(lstOccupationDetail.Result.Count > 0, "The actual count was greater than zero");
        }

        [Test]
        public void GetOccupationRatingDetails()
        {

            PortalServices portalServices = new PortalServices();
            var lstOccupationRatingDetail = portalServices.GetOccupationRatingDetails();

            Assert.IsTrue(lstOccupationRatingDetail.Result.Count > 0, "The actual count was greater than zero");
        }
    }
}