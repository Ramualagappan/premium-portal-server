using System;
using System.Collections.Generic;
using System.Text;
using Portal.EntityModel;

namespace Portal.EntityModel
{
    public class OccupationRating
    {
        public int RatingId { get; set; }
        public double Factor { get; set; }
        public string Rating { get; set; } 
        public ICollection<OccupationDetails> lstOccupationDetails { get; set; }
    }
}
