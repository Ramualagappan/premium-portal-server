using Portal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portal.services
{
    public interface IPortalServices
    {

        Task<IList<OccupationDetails>> GetOccupationDetails();
        decimal CalculatePremium(UserDetails userDetails);
    }
}
