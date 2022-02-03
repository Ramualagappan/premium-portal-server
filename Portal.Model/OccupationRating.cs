using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model
{
    public class OccupationRating
    {
        public int RatingId { get; set; }
        public double Factor { get; set; }
        public string Rating { get; set; } 
        public ICollection<OccupationDetails> lstOccupationDetails { get; set; }
    }
}
