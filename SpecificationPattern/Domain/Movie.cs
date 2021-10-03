using System;

namespace SpecificationPattern.Domain
{
    public class Movie : Entity
    {
        public string Name { get; }
        public DateTime ReleaseDate { get; }
        public MpaaRating MpaaRating { get; }
        public string Genre { get; }
        public double Rating { get; }

        public Movie(MpaaRating mpaa)
        {
            MpaaRating = mpaa;
        }

        public Movie(MpaaRating mpaa, double rating) : this(mpaa)
        {
            Rating = rating;
        }
    }
}
