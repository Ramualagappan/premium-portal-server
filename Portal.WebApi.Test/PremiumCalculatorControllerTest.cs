using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Portal.Model;
using Portal.Premium.Repository;
using Portal.services;
using PremiumCalculator.Controllers;
using System;

namespace Portal.WebApi.Test
{
    [TestClass]
    public class PremiumCalculatorControllerTest
    {
        private Mock<IPortalServices> _portalServices;
        private UserDetails userDetails;

        [TestInitialize]
        public void Setup()
        {

            _portalServices = new Mock<IPortalServices>();

            //Initial data setup
            userDetails = new UserDetails();
            userDetails.Age = 32;
            userDetails.Deathsuminsured = 5000;
            userDetails.Name = "Test Users";
            userDetails.DOB = DateTime.Now.AddYears(-32);
            userDetails.OccupationRating = 1;
        }

        [TestMethod]
        public void CalculatePremium_Positive()
        {
            _portalServices.Setup(p => p.CalculatePremium(userDetails)).Returns(1920);
            var totalPremium = _portalServices.Object.CalculatePremium(userDetails);

            Assert.AreEqual(totalPremium, 1920);
        }

        [TestMethod]
        public void CalculatePremium_Negative()
        {
            _portalServices.Setup(p => p.CalculatePremium(userDetails)).Returns(1920);
            var totalPremium = _portalServices.Object.CalculatePremium(userDetails);

            Assert.AreNotEqual(totalPremium, 1921);
        }

        [TestCleanup]
        public void CleanUp()
        {
            userDetails = null;
            _portalServices = null;
        }
    }
}
