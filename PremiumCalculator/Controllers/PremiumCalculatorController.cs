using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portal.Model;
using Portal.services;

namespace PremiumCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremiumCalculatorController : ControllerBase
    {
        private IPortalServices _portalServices;
        public PremiumCalculatorController(IPortalServices portalServices)
        {
            _portalServices = portalServices;
        }

        [HttpGet]
        public IEnumerable<OccupationDetails> Get()
        {
            return _portalServices.GetOccupationDetails().Result;
        }

        [HttpPost]
        public decimal Post([FromBody] UserDetails userDetails)
        {
            return _portalServices.CalculatePremium(userDetails);
        }
    }
}
