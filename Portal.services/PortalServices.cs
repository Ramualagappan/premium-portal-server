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

        public decimal CalculatePremium(UserDetails userDetails)
        {
            var OccupationRating = new Dictionary<string, double>(){
                {"Professional", 1.0},
                {"White Collar", 1.25},
                {"Light Manual", 1.50},
                {"Heavy Manual", 1.75},
            };

            double rating = OccupationRating.Where(p => p.Key == userDetails.Occupation).FirstOrDefault().Value;

            //Death Premium = (Death Cover amount *Occupation Rating Factor *Age) / 1000 * 12

            return ((userDetails.Deathsuminsured * Convert.ToDecimal(rating) * userDetails.Age) / 1000 * 12);
        }
    }
}
