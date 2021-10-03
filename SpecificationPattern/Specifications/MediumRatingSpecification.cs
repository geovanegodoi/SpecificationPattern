using SpecificationPattern.Domain;
using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specifications
{
    public class MediumRatingSpecification : Specification<Movie>
    {
        public override bool IsSatisfiedBy(Movie entity)
            => entity.Rating == 5;
    }
}
