using SpecificationPattern.Domain;
using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specifications
{
    public class GoodRatingSpecification : Specification<Movie>
    {
        public override bool IsSatisfiedBy(Movie entity)
            => entity.Rating > 5;
    }
}
