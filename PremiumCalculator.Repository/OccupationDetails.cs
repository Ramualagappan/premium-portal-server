using Portal.Model;
using System;

namespace Portal.Model
{
    public class OccupationDetails
    {
        public string Occupation { get; set; }
        public string Rating { get; set; }

        public OccupationRating OccupationRating { get; set; }
}
}
