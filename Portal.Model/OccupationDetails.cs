using System;
using System.Collections.Generic;

namespace Portal.Model
{
    public class OccupationDetails
    {
        public int Id { get; set; }
        public string Occupation { get; set; }
        public int RatingId { get; set; }
        public OccupationRating OccupationRating { get; set; }
    }
}
