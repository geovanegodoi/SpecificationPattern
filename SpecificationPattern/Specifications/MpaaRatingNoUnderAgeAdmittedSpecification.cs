using SpecificationPattern.Domain;
using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specifications
{
    public class MpaaRatingNoUnderAgeAdmittedSpecification : Specification<Movie>
    {
        public override bool IsSatisfiedBy(Movie entity)
            => entity.MpaaRating == MpaaRating.X;
    }
}
