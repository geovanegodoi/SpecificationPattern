using SpecificationPattern.Domain;
using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specifications
{
    public class MpaaRatingAtMostSpecification : Specification<Movie>
    {
        private readonly MpaaRating _rating;
 
        public MpaaRatingAtMostSpecification(MpaaRating rating)
        {
            _rating = rating;
        }

        public override bool IsSatisfiedBy(Movie entity)
            => entity.MpaaRating <= _rating;
    }
}
