using SpecificationPattern.Domain;
using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specifications
{
    public class GoodRatingForAllAgesSpecification : Specification<Movie>
    {
        public override bool IsSatisfiedBy(Movie entity)
            => new GoodRatingSpecification()
                .And(new MpaaRatingAllAgesSpecification())
                    .IsSatisfiedBy(entity);
    }

    public class ForAllAgesAndNotBadRatingSpecification : Specification<Movie>
    {
        public override bool IsSatisfiedBy(Movie entity)
            => new MpaaRatingAllAgesSpecification()
                .Not(new BadRatingSpecification())
                    .IsSatisfiedBy(entity);
    }
}
