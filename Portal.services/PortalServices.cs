using Portal.Model;
using Portal.Premium.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Portal.services
{
    public class PortalServices : IPortalServices
    {
        private readonly PortalContext _dbContext;

        public PortalServices(PortalContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<OccupationDetails>> GetOccupationDetails()
        {
            var Occupation = _dbContext.OccupationDetails.Include(n => n.OccupationRating).Select(cr => new OccupationDetails
            {
                Occupation = cr.Occupation,
                RatingId = cr.OccupationRating.RatingId
            }).ToList();

            return await Task.FromResult(Occupation);
        }

        public async Task<IList<OccupationViewModel>> GetOccupationRatingDetails()
        {
            List<OccupationViewModel> lstOccupationRating = _dbContext.OccupationDetails.Include(n => n.OccupationRating)
                .Select(cr => new OccupationViewModel
                {
                    Occupation = cr.Occupation,
                    RatingId = cr.OccupationRating.RatingId,
                    Factor = cr.OccupationRating.Factor,
                    Rating = cr.OccupationRating.Rating
                }).ToList();

            return await Task.FromResult(lstOccupationRating);
        }

        public decimal CalculatePremium(UserDetails userDetails)
        {
            double rating = _dbContext.OccupationDetails.Include(n => n.OccupationRating)
                .Where(p => p.OccupationRating.RatingId == userDetails.OccupationRating)
                .Select(n => n.OccupationRating.Factor).FirstOrDefault();

            /*Calculation logic below & Formula 
            Death Premium = (Death Cover amount *Occupation Rating Factor *Age) / 1000 * 12  */
            return ((userDetails.Deathsuminsured * Convert.ToDecimal(rating) * userDetails.Age) / 1000 * 12);
        }
    }
}
