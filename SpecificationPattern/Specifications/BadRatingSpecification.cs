using SpecificationPattern.Domain;
using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specifications
{
    public class BadRatingSpecification : Specification<Movie>
    {
        public override bool IsSatisfiedBy(Movie entity)
            => entity.Rating < 5;
    }
}
