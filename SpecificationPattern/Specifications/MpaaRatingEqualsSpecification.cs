using SpecificationPattern.Domain;
using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specifications
{
    public class MpaaRatingEqualsSpecification : Specification<Movie>
    {
        private readonly MpaaRating _rating;

        public MpaaRatingEqualsSpecification(MpaaRating rating)
        {
            _rating = rating;
        }

        public override bool IsSatisfiedBy(Movie entity)
            => entity.MpaaRating == _rating;
    }
}
