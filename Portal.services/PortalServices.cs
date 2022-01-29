using Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.services
{
    public class PortalServices: IPortalServices
    {

        public async Task<IList<OccupationDetails>> GetOccupationDetails()
        {
            List<OccupationDetails> Occupation = new List<OccupationDetails>(){
             new OccupationDetails{ Occupation="Cleaner", Rating="Light Manual"},
             new OccupationDetails{ Occupation="Doctor", Rating="Professional"},
             new OccupationDetails{ Occupation="Author", Rating="White Collar"},
             new OccupationDetails{ Occupation="Farmer", Rating="Heavy Manual"},
             new OccupationDetails{ Occupation="Mechanic", Rating="Heavy Manual"},
             new OccupationDetails{ Occupation="Florist", Rating="Light Manual"},
            };

            return await Task.FromResult(Occupation);
        }


        public async Task<IList<OccupationRating>> GetOccupationRatingDetails()
        {
            List<OccupationRating> lstOccupationRating = new List<OccupationRating>(){
               new OccupationRating { Rating= "Professional", Factor= 1.0},
                new OccupationRating { Rating = "White Collar", Factor = 1.25 },
                new OccupationRating { Rating = "Light Manual", Factor = 1.50 },
                new OccupationRating { Rating = "Heavy Manual", Factor = 1.75 },
            };

            return await Task.FromResult(lstOccupationRating);
        }

        public decimal CalculatePremium(UserDetails userDetails)
        {
            var lstOccupationRating = GetOccupationRatingDetails();

            double rating = lstOccupationRating.Result.Where(p => p.Rating == userDetails.Occupation).FirstOrDefault().Factor;

            //Death Premium = (Death Cover amount *Occupation Rating Factor *Age) / 1000 * 12

            return ((userDetails.Deathsuminsured * Convert.ToDecimal(rating) * userDetails.Age) / 1000 * 12);
        }
    }
}
